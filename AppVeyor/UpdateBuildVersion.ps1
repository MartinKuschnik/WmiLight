Write-Host "Patching Build Version to..." -NoNewline

$version = $(select-string -Path "WmiLight\Properties\AssemblyInfo.cs" -Pattern "(?<=AssemblyVersion\("").*(?=\.\*""\)])" -AllMatches | % { $_.Matches } | % { $_.Value }) + $(Get-Date -format ".yy") + $(Get-Date).DayOfYear.ToString().PadLeft(3, '0') + "." + $($env:appveyor_build_number)

Update-AppveyorBuild -Version $version

Write-Host $version -foregroundcolor "green"