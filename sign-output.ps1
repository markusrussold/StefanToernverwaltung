param(
    [Parameter(Mandatory = $true)]
    [string]$TargetPath
)

$ErrorActionPreference = 'Stop'

if (-not (Test-Path -LiteralPath $TargetPath)) {
    Write-Host "sign-output: target not found: $TargetPath"
    exit 0
}

$subject = 'CN=StefanToernverwaltung Local Dev'
$cert = Get-ChildItem Cert:\CurrentUser\My -CodeSigningCert -ErrorAction SilentlyContinue |
    Where-Object { $_.Subject -eq $subject -and $_.NotAfter -gt (Get-Date) } |
    Select-Object -First 1

if (-not $cert) {
    $cert = New-SelfSignedCertificate `
        -Type CodeSigningCert `
        -Subject $subject `
        -CertStoreLocation 'Cert:\CurrentUser\My' `
        -KeyExportPolicy Exportable `
        -NotAfter (Get-Date).AddYears(5)

    $tmp = Join-Path $env:TEMP 'StefanToernverwaltung-codesign.cer'
    Export-Certificate -Cert $cert -FilePath $tmp -Force | Out-Null
    Import-Certificate -FilePath $tmp -CertStoreLocation Cert:\CurrentUser\TrustedPublisher | Out-Null
    Import-Certificate -FilePath $tmp -CertStoreLocation Cert:\CurrentUser\Root | Out-Null
    Remove-Item $tmp -Force -ErrorAction SilentlyContinue
}

try {
    $sig = Set-AuthenticodeSignature -FilePath $TargetPath -Certificate $cert -HashAlgorithm SHA256
    Write-Host "sign-output: $($sig.Status) -> $TargetPath"
} catch {
    Write-Host "sign-output: skipped ($($_.Exception.Message))"
}
