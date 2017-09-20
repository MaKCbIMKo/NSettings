Import-Module $PSScriptRoot\shared.ps1

Write-Host "# Build has been begun"

Write-Host "# Restore NuGet packages"
__exec msbuild /t:restore /logger:"C:\Program Files\AppVeyor\BuildAgent\Appveyor.MSBuildLogger.dll"

Write-Host "# Build solution"
__exec msbuild /t:build /logger:"C:\Program Files\AppVeyor\BuildAgent\Appveyor.MSBuildLogger.dll"

Write-Host "# Build has been finished"