<#
.SYNOPSIS
  Bumps the Törnverwaltung product version (X.ZZ.Y).

.PARAMETER Part
  major = X+1, ZZ=00, Y=00  (database / breaking)
  minor = ZZ+1, Y=00        (feature)
  patch = Y+1               (bugfix)

.EXAMPLE
  powershell -NoProfile -File tools\bump-version.ps1 -Part patch
#>
param(
  [Parameter(Mandatory = $true)]
  [ValidateSet("major", "minor", "patch")]
  [string]$Part
)

$ErrorActionPreference = "Stop"
$root = Split-Path -Parent $PSScriptRoot
if (-not (Test-Path (Join-Path $root "Helpers\AppVersion.vb"))) {
  $root = (Get-Location).Path
}

$appVersionPath = Join-Path $root "Helpers\AppVersion.vb"
$assemblyInfoPath = Join-Path $root "My Project\AssemblyInfo.vb"
$readmePath = Join-Path $root "README.md"

function Get-CurrentVersion {
  $text = [IO.File]::ReadAllText($appVersionPath)
  if ($text -notmatch 'Public Const Number As String = "(\d+)\.(\d+)\.(\d+)"') {
    throw "Could not parse AppVersion.Number in $appVersionPath"
  }
  return [pscustomobject]@{
    Major = [int]$Matches[1]
    Minor = [int]$Matches[2]
    Patch = [int]$Matches[3]
  }
}

function Format-DisplayVersion($v) {
  return ("{0}.{1:D2}.{2:D2}" -f $v.Major, $v.Minor, $v.Patch)
}

function Format-AssemblyVersion($v) {
  return ("{0}.{1}.{2}.0" -f $v.Major, $v.Minor, $v.Patch)
}

$current = Get-CurrentVersion
$next = [pscustomobject]@{
  Major = $current.Major
  Minor = $current.Minor
  Patch = $current.Patch
}

switch ($Part) {
  "major" { $next.Major++; $next.Minor = 0; $next.Patch = 0 }
  "minor" { $next.Minor++; $next.Patch = 0 }
  "patch" { $next.Patch++ }
}

$oldDisplay = Format-DisplayVersion $current
$newDisplay = Format-DisplayVersion $next
$newAssembly = Format-AssemblyVersion $next

Write-Host "Bumping $Part : $oldDisplay -> $newDisplay"

# AppVersion.vb
$appText = [IO.File]::ReadAllText($appVersionPath)
$appText2 = [regex]::Replace(
  $appText,
  'Public Const Number As String = "\d+\.\d+\.\d+"',
  "Public Const Number As String = `"$newDisplay`"")
if ($appText2 -eq $appText) { throw "Failed to update AppVersion.vb" }
[IO.File]::WriteAllText($appVersionPath, $appText2)

# AssemblyInfo.vb
$asmText = [IO.File]::ReadAllText($assemblyInfoPath)
$asmText2 = [regex]::Replace($asmText, 'AssemblyVersion\("[^"]+"\)', "AssemblyVersion(`"$newAssembly`")")
$asmText2 = [regex]::Replace($asmText2, 'AssemblyFileVersion\("[^"]+"\)', "AssemblyFileVersion(`"$newAssembly`")")
if ($asmText2 -eq $asmText) { throw "Failed to update AssemblyInfo.vb" }
[IO.File]::WriteAllText($assemblyInfoPath, $asmText2)

# README.md (optional)
if (Test-Path $readmePath) {
  $readme = [IO.File]::ReadAllText($readmePath)
  $readme2 = [regex]::Replace($readme, '\*\*Aktuelle Version:\*\*\s*\d+\.\d+\.\d+', "**Aktuelle Version:** $newDisplay")
  if ($readme2 -ne $readme) {
    [IO.File]::WriteAllText($readmePath, $readme2)
  }
}

Write-Host "Updated:"
Write-Host "  Helpers\AppVersion.vb  Number=$newDisplay"
Write-Host "  My Project\AssemblyInfo.vb  $newAssembly"
Write-Host "  README.md (if present)"
Write-Host ""
Write-Host "Next: build, then git commit -m `"Bump version to $newDisplay`""
