# Toolchain bootstrap for the Windows GitLab runner (shell executor).
# Dot-source from before_script. Installs, once per machine, into the
# runner's per-machine tools directory (no admin, no winget needed):
#   - .NET SDK 9.0 (official zip; `dotnet restore` + the SDK that the
#     SDK-style projects resolve, as setup-dotnet 9.0.x did on GitHub)
#   - Inno Setup 6 (per-user, silent; same pin and folder as
#     CameraMeasurementTool, so the two share one copy)
#   - the .NET Framework 4.0 offline installer the setup bundles
# and puts them on PATH / in $env:ISCC, $env:MSBUILD, $env:DOTNETFX40_EXE.
# Every download is pinned and SHA-256 checked; a download that fails the
# check is moved aside to <name>.bad-<timestamp> (never deleted) and fetched
# once more. No other existing file in the tools dir is modified, moved or
# removed (Tagestry's plain `dotnet` dir is left alone; this uses
# dotnet-sdk-<version>).
#
# MSBuild: the solution must be built by Visual Studio's (full .NET
# Framework) MSBuild, not `dotnet build`. Two .resx files carry
# BinaryFormatter images/icons, and MSBuild on .NET Core refuses those for a
# .NET Framework target (MSB3822/MSB3823, reproduced with SDK 9.0.121). The
# GitHub workflow used the VS MSBuild on windows-latest for the same reason.
# Visual Studio / Build Tools cannot be installed without admin, so this
# script only finds it (vswhere) and stops with the one-time install command
# if it is missing.
$ErrorActionPreference = 'Stop'
[Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12

# .NET SDK 9.0.1xx: the 9.0 band with the lowest MSBuild floor (17.11,
# from sdk\9.0.121\minimumMSBuildVersion). SHA-512 matches Microsoft's
# releases.json; SHA-256 computed from the same download.
$DotnetSdkVersion = '9.0.121'
$DotnetSdkSha256  = 'a1302e6f307fa627c17a2f9341784de6fb16c4443eed25b7aaa105ec1b7c868b'
$MinMSBuild       = '17.11'
$InnoVersion      = '6.7.3'
$InnoSha256       = '9c73c3bae7ed48d44112a0f48e66742c00090bdb5bef71d9d3c056c66e97b732'
$DotNetFx40Url    = 'https://download.microsoft.com/download/9/5/A/95A9616B-7A37-4AF6-BC36-D6EA96C8DAAE/dotNetFx40_Full_x86_x64.exe'
$DotNetFx40Sha256 = '65e064258f2e418816b304f646ff9e87af101e4c9552ab064bb74d281c38659f'

$Tools = Join-Path $env:ProgramData 'gitlab-runner-tools'
$Downloads = Join-Path $Tools 'downloads'
New-Item -ItemType Directory -Force $Tools, $Downloads | Out-Null

# Download $Url to $Downloads\$Name (reused if already there) and fail unless
# its SHA-256 matches. A cached copy that fails the check (truncated or
# corrupt) is moved aside to <name>.bad-<timestamp> (kept for inspection,
# never deleted) and downloaded once more; only a second mismatch fails.
# Returns the local path.
function Get-VerifiedDownload([string]$Url, [string]$Name, [string]$Sha256) {
  $out = Join-Path $Downloads $Name
  foreach ($attempt in 1, 2) {
    if (-not (Test-Path $out)) {
      Write-Host "Downloading $Url"
      $ProgressPreference = 'SilentlyContinue'   # progress bar makes IWR very slow on 5.1
      Invoke-WebRequest $Url -OutFile "$out.part" -UseBasicParsing
      Move-Item "$out.part" $out -Force
    }
    $actual = (Get-FileHash -Algorithm SHA256 $out).Hash
    if ($actual -eq $Sha256.ToUpperInvariant()) { return $out }
    if ($attempt -eq 2) {
      throw "SHA-256 mismatch for ${Name} after a fresh download: expected $Sha256, got $actual"
    }
    $bad = "$out.bad-$(Get-Date -Format 'yyyyMMddHHmmss')"
    Move-Item $out $bad
    Write-Warning "SHA-256 mismatch for ${Name} (got $actual, expected $Sha256); moved aside to $bad (not deleted), downloading once more"
  }
}

# ---- .NET SDK --------------------------------------------------------------
# Unpacked into a staging folder first and renamed into place, so a job that
# is cancelled mid-extract never leaves a half SDK at the final path. A
# leftover staging folder from such a run is moved aside, not deleted.
$dotnet = Join-Path $Tools "dotnet-sdk-$DotnetSdkVersion"
if (-not (Test-Path (Join-Path $dotnet "sdk\$DotnetSdkVersion\dotnet.dll"))) {
  if (Test-Path $dotnet) { throw "$dotnet exists but has no sdk\$DotnetSdkVersion; move it aside and re-run" }
  Write-Host "Installing .NET SDK $DotnetSdkVersion into $dotnet"
  $zip = Get-VerifiedDownload "https://builds.dotnet.microsoft.com/dotnet/Sdk/$DotnetSdkVersion/dotnet-sdk-$DotnetSdkVersion-win-x64.zip" `
                              "dotnet-sdk-$DotnetSdkVersion-win-x64.zip" $DotnetSdkSha256
  $staging = Join-Path $Tools "staging\dotnet-sdk-$DotnetSdkVersion"
  if (Test-Path $staging) {
    $old = "$staging.old-$(Get-Date -Format 'yyyyMMddHHmmss')"
    Move-Item $staging $old
    Write-Warning "Moved an unfinished SDK extract aside to $old (not deleted)"
  }
  New-Item -ItemType Directory -Force (Split-Path $staging) | Out-Null
  Add-Type -AssemblyName System.IO.Compression.FileSystem
  [System.IO.Compression.ZipFile]::ExtractToDirectory($zip, $staging)
  Move-Item $staging $dotnet
}

# ---- Inno Setup ------------------------------------------------------------
$inno = Join-Path $Tools "innosetup-$InnoVersion"
if (-not (Test-Path (Join-Path $inno 'ISCC.exe'))) {
  Write-Host "Installing Inno Setup $InnoVersion into $inno"
  $setup = Get-VerifiedDownload "https://github.com/jrsoftware/issrc/releases/download/is-$($InnoVersion -replace '\.','_')/innosetup-$InnoVersion.exe" `
                                "innosetup-$InnoVersion.exe" $InnoSha256
  $p = Start-Process $setup -Wait -PassThru -ArgumentList @(
    '/VERYSILENT', '/SUPPRESSMSGBOXES', '/NORESTART', '/SP-', '/CURRENTUSER',
    "/DIR=`"$inno`"", '/NOICONS')
  if ($p.ExitCode -ne 0) { throw "Inno Setup installer failed (exit $($p.ExitCode))" }
  if (-not (Test-Path (Join-Path $inno 'ISCC.exe'))) { throw "ISCC.exe not found in $inno after install" }
}

# ---- .NET Framework 4.0 offline installer (bundled into the setup) ---------
$env:DOTNETFX40_EXE = Get-VerifiedDownload $DotNetFx40Url 'dotNetFx40_Full_x86_x64.exe' $DotNetFx40Sha256

# ---- MSBuild (Visual Studio / Build Tools, found, not installed) ------------
$vswhere = Join-Path ${env:ProgramFiles(x86)} 'Microsoft Visual Studio\Installer\vswhere.exe'
$msbuild = $null
if (Test-Path $vswhere) {
  $msbuild = & $vswhere -latest -products * -requires Microsoft.Component.MSBuild `
                        -version "[$MinMSBuild,)" -find 'MSBuild\**\Bin\MSBuild.exe' |
             Select-Object -First 1
}
if (-not $msbuild -or -not (Test-Path $msbuild)) {
  throw @"
No Visual Studio MSBuild $MinMSBuild or newer on this runner (looked with $vswhere).
QBTag must be built with Visual Studio's MSBuild (see the comment at the top
of ci\tools-windows.ps1). Install Visual Studio 2022 Build Tools once, as an
administrator, e.g.:
  winget install --id Microsoft.VisualStudio.2022.BuildTools --override "--quiet --wait --norestart --add Microsoft.VisualStudio.Workload.ManagedDesktopBuildTools"
then re-run the pipeline.
"@
}

$env:PATH = "$dotnet;$env:PATH"
$env:DOTNET_ROOT = $dotnet
# Make VS MSBuild's SDK resolver use this SDK, not whatever else is installed.
$env:DOTNET_MSBUILD_SDK_RESOLVER_CLI_DIR = $dotnet
$env:DOTNET_MULTILEVEL_LOOKUP = '0'
$env:DOTNET_CLI_TELEMETRY_OPTOUT = '1'
$env:DOTNET_NOLOGO = '1'
$env:DOTNET_SKIP_FIRST_TIME_EXPERIENCE = '1'
$env:NUGET_PACKAGES = Join-Path $Tools 'nuget-packages'
$env:MSBUILD = $msbuild
$env:ISCC = Join-Path $inno 'ISCC.exe'

$msbuildVersion = (& $msbuild -nologo -version | Select-Object -Last 1)
Write-Host ("dotnet {0} / MSBuild {1} ({2}) / ISCC {3}" -f (& dotnet --version), "$msbuildVersion".Trim(), $msbuild, $env:ISCC)
