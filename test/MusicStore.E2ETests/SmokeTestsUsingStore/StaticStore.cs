using System;
using System.IO;
using System.IO.Compression;
using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Server.IntegrationTesting;
using Microsoft.Extensions.CommandLineUtils;
using Microsoft.Extensions.Logging;

namespace E2ETests
{
    internal class StaticStore : IStore
    {
        public const string MusicStoreUsePrebuiltAspNetCoreStore = "MUSICSTORE_USE_PREBUILT_ASPNETCORE_STORE";
        public const string MusicStoreAspNetCoreStoreZipLocation = "MUSICSTORE_ASPNETCORE_STORE_ZIP_LOCATION";
        private readonly ILogger _logger;
        private string _storeDir;

        public StaticStore(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<StaticStore>();
        }

        public string CreateStore(bool createInDefaultLocation)
        {
            if (!IsEnabled())
            {
                return null;
            }

            var zipFile = GetZipFile();
            var storeParentDir = GetStoreParentDirectory(createInDefaultLocation);

            try
            {
                _logger.LogInformation($"Extracing the zip file {zipFile} to directory {storeParentDir}");

                ZipFile.ExtractToDirectory(zipFile, storeParentDir);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error occurred while unzipping the file: {ex.ToString()}");
                throw ex;
            }

            _storeDir = Path.Combine(storeParentDir, "store");

            return _storeDir;
        }

        public void Dispose()
        {
            if (string.IsNullOrEmpty(_storeDir))
            {
                return;
            }

            if (Helpers.PreservePublishedApplicationForDebugging)
            {
                _logger.LogInformation("Skipping deleting the store as it has been disabled");
            }
            else
            {
                _logger.LogInformation("Deleting the store...");

                RetryHelper.RetryOperation(
                        () => Directory.Delete(_storeDir, recursive: true),
                        e => _logger.LogError($"Failed to delete directory : {e.Message}"),
                        retryCount: 3,
                        retryDelayMilliseconds: 100);
            }
        }

        public static bool IsEnabled()
        {
            var usePrebuiltStore = Environment.GetEnvironmentVariable(MusicStoreUsePrebuiltAspNetCoreStore);
            if (string.IsNullOrEmpty(usePrebuiltStore)
                || string.Equals(usePrebuiltStore, "false", StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }
            return true;
        }

        private string GetZipFile()
        {
            var storeZipLocation = Environment.GetEnvironmentVariable(MusicStoreAspNetCoreStoreZipLocation);
            if (string.IsNullOrEmpty(storeZipLocation))
            {
                _logger.LogError("The direcotry path for the store zip file was not provided." +
                    $"Set the environment variable '{MusicStoreAspNetCoreStoreZipLocation}' and try again.");

                throw new InvalidOperationException(
                    $"The environment variable '{MusicStoreAspNetCoreStoreZipLocation}' is not defined or is empty.");
            }
            else
            {
                _logger.LogInformation($"Using the direcotry path for the store zip file:{storeZipLocation}");
            }

            var zipFile = Path.Combine(storeZipLocation, "Build.RS.winx64.zip");
            if (!File.Exists(zipFile))
            {
                _logger.LogError($"Could not find the zip file: {zipFile}");
                throw new InvalidOperationException($"Could not find file '{zipFile}'");
            }
            return zipFile;
        }

        private string GetStoreParentDirectory(bool createInDefaultLocation)
        {
            string storeParentDir;
            if (createInDefaultLocation)
            {
                // On Windows: ..\.dotnet\x64\dotnet.exe
                // On Linux  : ../.dotnet/dotnet
                var dotnetDir = new FileInfo(DotNetMuxer.MuxerPath).Directory.FullName;

                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    storeParentDir = dotnetDir;
                }
                else
                {
                    storeParentDir = Path.Combine(dotnetDir, "x64");
                }
            }
            else
            {
                storeParentDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            }
            return storeParentDir;
        }
    }
}
