using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Server.IntegrationTesting;
using Microsoft.Extensions.CommandLineUtils;
using Microsoft.Extensions.Logging;

namespace E2ETests
{
    internal class DynamicStore : IStore
    {
        public const string MusicStoreAspNetCoreStore = "MUSICSTORE_ASPNETCORE_DYNAMIC_STORE";
        private readonly ILogger _logger;
        private string _storeDir;
        private string _storeWorkingDir;

        public DynamicStore(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<DynamicStore>();
        }

        public string CreateStore(bool createInDefaultLocation)
        {
            if (!IsEnabled())
            {
                return null;
            }

            _storeDir = GetStoreDirectory(createInDefaultLocation);
            _storeWorkingDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());

            var applicationPath = Helpers.GetApplicationPath(ApplicationType.Portable);
            var applicationProjFilePath = Path.Combine(applicationPath, "MusicStore.csproj");
            var parameters = $"store "
                + $" --framework netcoreapp2.0"
                + $" --configuration {Helpers.GetCurrentBuildConfiguration()}"
                + $" --runtime {GetRuntimeIdentifier()}"
                + $" --working-dir {_storeWorkingDir}"
                + $" --manifest {applicationProjFilePath}"
                + $" --preserve-working-dir";

            if (!createInDefaultLocation)
            {
                parameters += $" --output {_storeDir}";
            }

            _logger.LogInformation($"Executing command: dotnet {parameters}");

            var startInfo = new ProcessStartInfo
            {
                FileName = "dotnet",
                Arguments = parameters,
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardError = true,
                RedirectStandardOutput = true,
                WorkingDirectory = applicationPath,
            };

            var hostProcess = new Process() { StartInfo = startInfo };

            hostProcess.StartAndCaptureOutAndErrToLogger(prefix: "", logger: _logger);

            hostProcess.WaitForExit();

            if (hostProcess.ExitCode != 0)
            {
                var message = $"dotnet store exited with exit code : {hostProcess.ExitCode}";
                throw new Exception(message);
            }

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
                _logger.LogInformation("Skipping deleting the store and working directory as it has been disabled");
            }
            else
            {
                _logger.LogInformation("Deleting the storing and working directory.");

                RetryHelper.RetryOperation(
                        () => Directory.Delete(_storeDir, recursive: true),
                        e => _logger.LogError($"Failed to delete directory : {e.Message}"),
                        retryCount: 3,
                        retryDelayMilliseconds: 100);

                RetryHelper.RetryOperation(
                        () => Directory.Delete(_storeWorkingDir, recursive: true),
                        e => _logger.LogError($"Failed to delete directory : {e.Message}"),
                        retryCount: 3,
                        retryDelayMilliseconds: 100);
            }
        }

        public static bool IsEnabled()
        {
            var useStore = Environment.GetEnvironmentVariable(MusicStoreAspNetCoreStore);
            if (string.IsNullOrEmpty(useStore)
                || string.Equals(useStore, "false", StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }
            return true;
        }

        private string GetStoreDirectory(bool createInDefaultLocation)
        {
            string storeDirectory;
            if (createInDefaultLocation)
            {
                // On Windows: ..\.dotnet\x64\dotnet.exe
                // On Linux  : ../.dotnet/dotnet
                var dotnetDir = new FileInfo(DotNetMuxer.MuxerPath).Directory.FullName;

                // On Windows: ..\.dotnet\x64\store
                // On Linux  : ../.dotnet/x64/store
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    storeDirectory = Path.Combine(dotnetDir, "store");
                }
                else
                {
                    storeDirectory = Path.Combine(dotnetDir, "x64", "store");
                }
            }
            else
            {
                storeDirectory = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            }
            return storeDirectory;
        }

        private string GetRuntimeIdentifier()
        {
            var architecture = GetArchitecture();
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return "win7-" + architecture;
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                return "linux-" + architecture;
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                return "osx-" + architecture;
            }
            else
            {
                throw new InvalidOperationException("Unrecognized operation system platform");
            }
        }

        private string GetArchitecture()
        {
            switch (RuntimeInformation.OSArchitecture)
            {
                case Architecture.X86:
                    return "x86";
                case Architecture.X64:
                    return "x64";
                default:
                    throw new NotSupportedException($"Unsupported architecture: {RuntimeInformation.OSArchitecture}");
            }
        }
    }
}
