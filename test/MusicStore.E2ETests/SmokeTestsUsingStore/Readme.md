FAQ
===

- What are these tests?  
  These tests publish MusicStore application by using the store. The effect of this is that MusicStore publish output
  would not contain ASP.NET Core dlls which reduces the size of the published output.

- How do I run them on my local dev box? 
  - Set environment variable or pass build property called 'AspNetCoreStore' with the location of the source of 
    'Microsoft.AspNetCore.All' package. The location can be a Url or a folder path.
  - Set environment variable called 'MUSICSTORE_ASPNETCORE_DYNAMIC_STORE' to 'true' for running these tests by 
    creating a store dynamically (which uses the `dotnet store` command).
  - Set environment variable called 'MUSICSTORE_USE_PREBUILT_ASPNETCORE_STORE' to 'true' for running these tests by
    unzipping an already created store. If set to 'true', also provide the folder path where the zipped store is
    present using the environment variable 'MUSICSTORE_ASPNETCORE_STORE_ZIP_LOCATION'.