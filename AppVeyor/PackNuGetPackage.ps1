Write-Host "Patching .nuspec version to..." -NoNewline

$root = (split-path -parent $MyInvocation.MyCommand.Definition) + '\..'
$version = [System.Reflection.Assembly]::LoadFile("$root\Goji\bin\Release\Goji.dll").GetName().Version
$versionStr = "{0}.{1}.{2}.{3}" -f ($version.Major, $version.Minor, $version.Build, $version.Revision)

Write-Host $versionStr -foregroundcolor "green"

$content = (Get-Content $root\AppVeyor\Goji.nuspec) 
$content = $content -replace '\$version\$',$versionStr

$content | Out-File $root\AppVeyor\Goji.nuspec

Write-Host "Creating NuGet package..." -NoNewline

& $root\AppVeyor\NuGet.exe pack $root\AppVeyor\Goji.nuspec -OutputDirectory $root\Goji\bin\Release\ -Verbosity "quiet"

Get-ChildItem -Path "$root\Goji\bin\Release\Goji.*.nupkg" -File | ForEach-Object{
    Write-Host "$($_.Name)" -ForegroundColor Green 
}

Push-AppveyorArtifact Goji\bin\Release\Goji.*.nupkg
