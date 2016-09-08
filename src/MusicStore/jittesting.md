###Instructions for JIT testing:

- `git clone <music store repo>`
- `git checkout jitbench`
- `cd src\MusicStore`
- `dotnet restore`
- `dotnet publish –c Release –f netcoreapp10`
- `cd bin\Release\netcoreapp1.0\publish`
- `.\crossgen-publish.ps1`
- `dotnet MusicStore.dll`

Currently the CoreCLR platform and version are hardcoded to `win7-x64` and `1.0.2`.
To change the platform or version, `$platform`, `$coreclrversion` and `$clrjitversion` needs to change accordingly in `src/MusicStore/get-crossgen.ps1`. 

###What this does?
- Downloads the specified CoreCLR and JIT packages from NuGet and extracts `crossgen.exe` and `clrjit.dll` from them.
- When `crossgen-publish.ps1` is run, it uses the `crossgen.exe` from the above step to crossgen the dlls in the publish output.
- When `dotnet Musicstore.dll` is run, it starts up the server, sends a request to `http:localhost:5000` and then shuts down.

Note:
The script currently doesn't work for non-windows platforms.