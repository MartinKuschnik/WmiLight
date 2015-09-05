Write-Host "Patching .nuspec version to..." -NoNewline

$root = (split-path -parent $MyInvocation.MyCommand.Definition) + '\..'
$version = [System.Reflection.Assembly]::LoadFile("$root\WmiLight\bin\Release\WmiLight.dll").GetName().Version
$versionStr = "{0}.{1}.{2}.{3}" -f ($version.Major, $version.Minor, $version.Build, $version.Revision)

Write-Host $versionStr -foregroundcolor "green"

$content = (Get-Content $root\AppVeyor\WmiLight.nuspec) 
$content = $content -replace '\$version\$',$versionStr

$content | Out-File $root\AppVeyor\WmiLight.nuspec

Write-Host "Creating NuGet package..." -NoNewline

& $root\AppVeyor\NuGet.exe pack $root\AppVeyor\WmiLight.nuspec -OutputDirectory $root\WmiLight\bin\Release\ -Verbosity "quiet"

Get-ChildItem -Path "$root\WmiLight\bin\Release\WmiLight.*.nupkg" -File | ForEach-Object{
    Write-Host "$($_.Name)" -ForegroundColor Green 
}

Push-AppveyorArtifact WmiLight\bin\Release\WmiLight.*.nupkg
