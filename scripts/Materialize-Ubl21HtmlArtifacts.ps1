# Extracts OASIS UBL 2.1 HTML documentation (and the db/ assets used by UBL-2.1.html)
# into repository-root artifacts/UBL-2.1-documentation/ (gitignored).
param(
    [string] $ZipPath,
    [string] $ZipUrl = 'https://docs.oasis-open.org/ubl/os-UBL-2.1/UBL-2.1.zip'
)

Set-StrictMode -Version Latest
$ErrorActionPreference = 'Stop'

$repoRoot = Resolve-Path (Join-Path $PSScriptRoot '..')
$outRoot = Join-Path $repoRoot 'artifacts/UBL-2.1-documentation'

if ($ZipPath) {
    $zipLocal = (Resolve-Path -LiteralPath $ZipPath).Path
} else {
    $zipLocal = Join-Path ([System.IO.Path]::GetTempPath()) 'Frank.UblSharp-UBL-2.1.zip'
    if (-not (Test-Path -LiteralPath $zipLocal)) {
        Write-Host "Downloading $ZipUrl ..."
        Invoke-WebRequest -Uri $ZipUrl -OutFile $zipLocal -UseBasicParsing
    }
}

$extractRoot = Join-Path ([System.IO.Path]::GetTempPath()) ('ubl21-extract-' + [Guid]::NewGuid().ToString('n'))
try {
    New-Item -ItemType Directory -Path $extractRoot -Force | Out-Null
    Expand-Archive -LiteralPath $zipLocal -DestinationPath $extractRoot -Force

    $flagship = Get-ChildItem -LiteralPath $extractRoot -Recurse -Filter 'UBL-2.1.html' -File |
        Select-Object -First 1
    if (-not $flagship) {
        throw "UBL-2.1.html not found inside the archive (unexpected layout)."
    }

    $bundleRoot = $flagship.Directory.FullName

    if (Test-Path -LiteralPath $outRoot) {
        Remove-Item -LiteralPath $outRoot -Recurse -Force
    }
    New-Item -ItemType Directory -Path $outRoot -Force | Out-Null

    Get-ChildItem -LiteralPath $bundleRoot -Recurse -Filter '*.html' -File | ForEach-Object {
        $relative = $_.FullName.Substring($bundleRoot.Length).TrimStart([char]'\', [char]'/')
        $dest = Join-Path $outRoot $relative
        $destDir = Split-Path -Parent $dest
        if (-not (Test-Path -LiteralPath $destDir)) {
            New-Item -ItemType Directory -Path $destDir -Force | Out-Null
        }
        Copy-Item -LiteralPath $_.FullName -Destination $dest -Force
    }

    $dbSource = Join-Path $bundleRoot 'db'
    if (Test-Path -LiteralPath $dbSource) {
        Copy-Item -LiteralPath $dbSource -Destination (Join-Path $outRoot 'db') -Recurse -Force
    }

    Write-Host "UBL 2.1 HTML documentation written to: $outRoot"
}
finally {
    if (Test-Path -LiteralPath $extractRoot) {
        Remove-Item -LiteralPath $extractRoot -Recurse -Force
    }
}
