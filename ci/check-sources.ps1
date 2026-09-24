# Pre-build checks for the GitLab pipeline (runs on the Linux runner with
# pwsh, before the Windows laptop is woken). Fails when something the
# installer or the version stamp relies on is missing from the repository:
#
#   - every project listed in QBTag.sln exists
#   - every project has Properties/AssemblyInfo.cs with exactly one
#     AssemblyVersion and one AssemblyFileVersion (ci/set-version.ps1 stamps
#     them on release builds)
#   - installer/QBTag.iss: the setup icon and every committed prerequisite
#     (QODBC, QuickBooks SDK 12.0, Crystal Reports runtime) exist. The .iss
#     marks those "skipifsourcedoesntexist", so without this check a missing
#     file would silently produce an installer without it. The .NET 4.0
#     installer is not committed; the Windows job downloads it (pinned).
#   - every file the installer takes from the build output folder is either
#     built by a project in the solution or staged from SupportingFiles/ by
#     the Windows job (reports, Product.xml, the exe manifest).
#
# Usage: pwsh -NoProfile -File ci/check-sources.ps1 [-Root <repo>]
param([string]$Root = '')
$ErrorActionPreference = 'Stop'
if (-not $Root) { $Root = Join-Path $PSScriptRoot '..' }
$Root = (Resolve-Path $Root).Path
$problems = New-Object System.Collections.Generic.List[string]

function Get-RepoPath([string]$rel) {
  # Solution/installer paths use backslashes; make them work on Linux too.
  return (Join-Path $Root ($rel -replace '\\', '/'))
}

# ---- solution projects + AssemblyInfo ------------------------------------
$sln = Get-Content -Raw (Join-Path $Root 'QBTag.sln')
$projects = [regex]::Matches($sln, 'Project\("\{[^}]+\}"\) = "([^"]+)", "([^"]+\.csproj)"')
if ($projects.Count -eq 0) { $problems.Add('QBTag.sln lists no C# projects') }

$buildOutputs = @{}
foreach ($p in $projects) {
  $csproj = Get-RepoPath $p.Groups[2].Value
  if (-not (Test-Path $csproj)) { $problems.Add("QBTag.sln project missing: $($p.Groups[2].Value)"); continue }
  $xml = [xml](Get-Content -Raw $csproj)
  $name = @($xml.Project.PropertyGroup | ForEach-Object { $_.AssemblyName } | Where-Object { $_ })[0]
  if (-not $name) { $name = [IO.Path]::GetFileNameWithoutExtension($csproj) }
  $type = @($xml.Project.PropertyGroup | ForEach-Object { $_.OutputType } | Where-Object { $_ })[0]
  if ($type -in 'WinExe', 'Exe') {
    $buildOutputs["$name.exe"] = $true
    if (Test-Path (Join-Path (Split-Path $csproj) 'app.config')) { $buildOutputs["$name.exe.config"] = $true }
  } else {
    $buildOutputs["$name.dll"] = $true
  }

  $info = Join-Path (Split-Path $csproj) 'Properties/AssemblyInfo.cs'
  if (-not (Test-Path $info)) { $problems.Add("$($p.Groups[1].Value): Properties/AssemblyInfo.cs missing"); continue }
  $text = Get-Content -Raw $info
  foreach ($attr in 'AssemblyVersion', 'AssemblyFileVersion') {
    $n = ([regex]::Matches($text, $attr + '\("[^"]*"\)')).Count
    if ($n -ne 1) { $problems.Add("$($p.Groups[1].Value): expected one $attr in AssemblyInfo.cs, found $n") }
  }
}

# ---- installer script -----------------------------------------------------
# Files the Windows job copies into the build output folder before ISCC runs
# (keep in sync with the "stage" step in .gitlab-ci.yml).
$staged = @{}
foreach ($pattern in 'SupportingFiles/Reports/*.rpt', 'SupportingFiles/Config/Product.xml', 'SupportingFiles/Config/QBTag.exe.manifest') {
  $found = @(Get-ChildItem -Path (Join-Path $Root $pattern) -File -ErrorAction SilentlyContinue)
  if ($found.Count -eq 0) { $problems.Add("staging source missing: $pattern") }
  foreach ($f in $found) { $staged[$f.Name] = $true }
}

$issPath = Join-Path $Root 'installer/QBTag.iss'
$iss = Get-Content $issPath
$issDir = Split-Path $issPath
# Files the Windows job downloads (pinned) into installer/prereqs.
$downloaded = @('dotNetFx40_Full_x86_x64.exe')

foreach ($line in $iss) {
  if ($line -match '^\s*SetupIconFile=(.+)$') {
    $icon = Join-Path $issDir ($Matches[1].Trim() -replace '\\', '/')
    if (-not (Test-Path $icon)) { $problems.Add("installer SetupIconFile missing: $($Matches[1].Trim())") }
  }
  if ($line -notmatch '^\s*Source:\s*"([^"]+)"') { continue }
  $src = $Matches[1]
  if ($src -match '^\{#BuildDir\}\\(.+)$') {
    $file = $Matches[1]
    if (-not ($buildOutputs.ContainsKey($file) -or $staged.ContainsKey($file))) {
      $problems.Add("installer takes $file from the build folder, but no project builds it and SupportingFiles does not stage it")
    }
    continue
  }
  $leaf = Split-Path ($src -replace '\\', '/') -Leaf
  if ($downloaded -contains $leaf) { continue }
  $path = Join-Path $issDir ($src -replace '\\', '/')
  if (-not (Test-Path $path)) { $problems.Add("installer source missing from the repository: $src") }
}

if ($problems.Count -gt 0) {
  $problems | ForEach-Object { Write-Host "FAIL: $_" }
  throw "$($problems.Count) source check(s) failed"
}
Write-Host ("OK: {0} projects, build outputs [{1}], staged [{2}]" -f $projects.Count,
  (($buildOutputs.Keys | Sort-Object) -join ', '), (($staged.Keys | Sort-Object) -join ', '))
