# Stamps a release version into every project's Properties\AssemblyInfo.cs
# (AssemblyVersion and AssemblyFileVersion become "<Version>.0"), the same
# edit the GitHub release workflow made from the tag. Used by the GitLab
# pipeline on release builds only; untagged builds keep the committed
# 3.0.3.0 like the GitHub build did.
#
# Runs under Windows PowerShell 5.1 (Windows runner) and pwsh 7 (Linux
# compile check). Files are rewritten as UTF-8 without BOM, which is how they
# are committed, so the (c) sign in AssemblyCopyright survives.
param(
  [Parameter(Mandatory = $true)][string]$Version,
  [string]$Root = ''
)
$ErrorActionPreference = 'Stop'
if (-not $Root) { $Root = Join-Path $PSScriptRoot '..' }

# AssemblyVersion needs four numeric parts, each 0..65535.
if ($Version -notmatch '^(\d+)\.(\d+)\.(\d+)$') {
  throw "Release version '$Version' is not X.Y.Z (numbers only); AssemblyVersion cannot carry it."
}
foreach ($part in $Matches[1], $Matches[2], $Matches[3]) {
  if ([int64]$part -gt 65535) { throw "Release version '$Version' has a part above 65535." }
}
$full = "$Version.0"

# One per project folder (<Project>/Properties/AssemblyInfo.cs); not a deep
# search, so restored packages or build output can never be touched.
$files = @(Get-ChildItem -Path (Join-Path $Root '*/Properties/AssemblyInfo.cs') -File)
if ($files.Count -eq 0) { throw "No AssemblyInfo.cs found under $Root" }

$utf8NoBom = New-Object System.Text.UTF8Encoding($false)
foreach ($f in $files) {
  $text = [System.IO.File]::ReadAllText($f.FullName)
  foreach ($attr in 'AssemblyVersion', 'AssemblyFileVersion') {
    $pattern = $attr + '\("[^"]*"\)'
    $n = ([regex]::Matches($text, $pattern)).Count
    if ($n -ne 1) { throw "$($f.FullName): expected exactly one $attr attribute, found $n" }
    $text = [regex]::Replace($text, $pattern, ($attr + '("' + $full + '")'))
  }
  [System.IO.File]::WriteAllText($f.FullName, $text, $utf8NoBom)
  Write-Host "Stamped $full into $($f.FullName)"
}
