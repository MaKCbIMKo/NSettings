Import-Module $PSScriptRoot\shared.ps1

Write-Host "# Packing projects has been begun"

Write-Host "# Pack projects to NuGet packages"
__exec msbuild /t:pack /logger:"C:\Program Files\AppVeyor\BuildAgent\Appveyor.MSBuildLogger.dll"

Write-Host "# Packing projects has been finished"