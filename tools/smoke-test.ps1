param(
  [Parameter(Mandatory = $false)]
  [string]$AppDir = (Join-Path $PSScriptRoot "..\bin\x86\Debug")
)

$ErrorActionPreference = "Stop"
$AppDir = [IO.Path]::GetFullPath($AppDir)
Write-Host "Smoke test against: $AppDir"

$exe = Join-Path $AppDir "Verwaltung.exe"
if (-not (Test-Path $exe)) {
  throw "Verwaltung.exe not found in $AppDir. Build Debug/Release x86 first."
}

$required = @(
  "Microsoft.VisualBasic.PowerPacks.Vs.dll",
  "Verwaltung.exe.config"
)

foreach ($name in $required) {
  $p = Join-Path $AppDir $name
  if (-not (Test-Path $p)) {
    Write-Warning "Missing: $name"
  } else {
    Write-Host "OK $name"
  }
}

# PE machine type should be x86 (0x14c)
$bytes = [IO.File]::ReadAllBytes($exe)
$peOffset = [BitConverter]::ToInt32($bytes, 0x3C)
$machine = [BitConverter]::ToUInt16($bytes, $peOffset + 4)
if ($machine -ne 0x14c) {
  throw "EXE is not x86 (machine=0x$($machine.ToString('X'))). Jet requires 32-bit."
}
Write-Host "OK PE machine = x86"

# Jet/ADOX probe via temporary VB-less COM check
$jetOk = $false
try {
  $cat = New-Object -ComObject ADOX.Catalog
  if ($null -ne $cat) { $jetOk = $true }
} catch {}
if (-not $jetOk) {
  try {
    $dao = New-Object -ComObject DAO.DBEngine.36
    if ($null -ne $dao) { $jetOk = $true }
  } catch {}
}
if ($jetOk) {
  Write-Host "OK Jet/ADOX or DAO COM available"
} else {
  Write-Warning "Jet/ADOX/DAO COM not detected. App may fail to create MDBs."
}

Write-Host "Smoke test finished."
