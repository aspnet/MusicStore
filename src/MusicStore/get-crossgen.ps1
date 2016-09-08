$platform = "win7-x64"

$coreclrpackage = "runtime.$platform.Microsoft.NETCore.Runtime.CoreCLR"
$coreclrversion = "1.0.2"

$clrjitpackage = "runtime.$platform.Microsoft.NETCore.Jit"
$clrjitversion = "1.0.2"

$nugeturl = "https://dist.nuget.org/win-x86-commandline/v3.4.4/NuGet.exe"
$nugetfeed = "https://www.nuget.org/api/v2"
$nugetexepath = "$PSScriptRoot\crossgen\NuGet.exe"
$wc = New-Object System.Net.WebClient
$wc.DownloadFile($nugeturl, $nugetexepath)

& "$nugetexepath" "install", "$coreclrpackage", "-Source", "$nugetfeed", "-Version", "$coreclrversion", "-OutputDirectory", "$PSScriptRoot\crossgen\"
Copy-Item "$PSScriptRoot\crossgen\$coreclrpackage.$coreclrversion\tools\crossgen.exe" "$PSScriptRoot\crossgen\crossgen.exe"
Remove-Item "$PSScriptRoot\crossgen\$coreclrpackage.$coreclrversion\" -recurse

& "$nugetexepath" "install", "$clrjitpackage", "-Source", "$nugetfeed", "-Version", "$clrjitversion", "-OutputDirectory", "$PSScriptRoot\crossgen\"
Copy-Item "$PSScriptRoot\crossgen\$clrjitpackage.$clrjitversion\runtimes\$platform\native\clrjit.dll" "$PSScriptRoot\crossgen\clrjit.dll"
Remove-Item "$PSScriptRoot\crossgen\$clrjitpackage.$clrjitversion\" -recurse

Remove-Item "$PSScriptRoot\crossgen\NuGet.exe"