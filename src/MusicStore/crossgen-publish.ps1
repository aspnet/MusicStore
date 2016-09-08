$sdk_dir = get-item "C:\Program Files\dotnet\shared\Microsoft.NETCore.App\1.0.0"
$crossgen_exe = get-item "$PSScriptRoot\crossgen\crossgen.exe"

foreach ($file in gci . -r -include *.dll)
{
    $out =[io.path]::ChangeExtension($file.Name, ".ni.dll")
    write-host $crossgen_exe /Platform_Assemblies_Paths """$sdk_dir""" /App_Paths """$PSScriptRoot"""/out $out $file
    & $crossgen_exe /Platform_Assemblies_Paths """$sdk_dir""" /App_Paths """$PSScriptRoot"""/out $out $file
    mv $out $file -force
}