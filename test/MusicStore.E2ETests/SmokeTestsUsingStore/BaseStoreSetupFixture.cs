using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Server.IntegrationTesting;
using Microsoft.Extensions.CommandLineUtils;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Testing;

namespace E2ETests
{
    /// <summary>
    /// Here store is setup dynamically on the fly using 'dotnet store'
    /// </summary>
    public class BaseStoreSetupFixture : IDisposable
    {
        public const string AspNetCoreStoreEnvironmentVariableName = "ASPNETCORE_STORE";
        public const string AspNetCoreStoreZipLocationEnvironmentVariableName = "ASPNETCORE_STORE_ZIP_LOCATION";

        private ILoggerFactory _loggerFactory;
        private readonly IDisposable _logToken;
        private readonly ILogger<BaseStoreSetupFixture> _logger;
        private string _storeWorkingDir;

        public BaseStoreSetupFixture(bool createInDefaultLocation, string loggerName, bool createStore)
        {
            var useAspNetCoreStore = Environment.GetEnvironmentVariable(AspNetCoreStoreEnvironmentVariableName);
            if (useAspNetCoreStore == null || string.Equals(useAspNetCoreStore, "false", StringComparison.OrdinalIgnoreCase))
            {
                return;
            }

            var testLog = AssemblyTestLog.ForAssembly(typeof(BaseStoreSetupFixture).Assembly);
            _logToken = testLog.StartTestLog(null, loggerName, out _loggerFactory, testName: loggerName);
            _logger = _loggerFactory.CreateLogger<BaseStoreSetupFixture>();

            CreateStoreInDefaultLocation = createInDefaultLocation;

            _logger.LogInformation(
                "Setting up store in the location: {location}",
                CreateStoreInDefaultLocation ? "default" : "custom");

            if (CreateStoreInDefaultLocation)
            {
                // On Windows: ..\.dotnet\x64\dotnet.exe
                // On Linux  : ../.dotnet/dotnet
                var dotnetDir = new FileInfo(DotNetMuxer.MuxerPath).Directory.FullName;

                // On Windows: ..\.dotnet\x64\store
                // On Linux  : ../.dotnet/x64/store
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    StoreDirectory = Path.Combine(dotnetDir, "store");
                }
                else
                {
                    StoreDirectory = Path.Combine(dotnetDir, "x64", "store");
                }
            }
            else
            {
                StoreDirectory = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            }

            if (createStore)
            {
                CreateStore();
            }
            else
            {
                var rootPath = Environment.GetEnvironmentVariable(AspNetCoreStoreZipLocationEnvironmentVariableName);
                if (string.IsNullOrEmpty(rootPath))
                {
                    throw new InvalidOperationException(
                        $"The environment variable '{AspNetCoreStoreZipLocationEnvironmentVariableName}' is not defined or is empty.");
                }

                var zipFile = Path.Combine(rootPath, "Build.RS.winx64.zip");
                if (!File.Exists(zipFile))
                {
                    throw new InvalidOperationException($"Could not find file '{zipFile}'");
                }

                ZipFile.ExtractToDirectory(zipFile, StoreDirectory);
            }
        }

        public bool CreateStoreInDefaultLocation { get; set; }

        public string StoreDirectory { get; private set; }

        public void Dispose()
        {
            if (_logger == null)
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
                        () => Directory.Delete(StoreDirectory, recursive: true),
                        e => _logger.LogError($"Failed to delete directory : {e.Message}"),
                        retryCount: 3,
                        retryDelayMilliseconds: 100);

                RetryHelper.RetryOperation(
                        () => Directory.Delete(_storeWorkingDir, recursive: true),
                        e => _logger.LogError($"Failed to delete directory : {e.Message}"),
                        retryCount: 3,
                        retryDelayMilliseconds: 100);
            }
            _logToken.Dispose();
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

        private void CreateStore()
        {
            var applicationPath = Helpers.GetApplicationPath(ApplicationType.Portable);
            var applicationProjFilePath = Path.Combine(applicationPath, "MusicStore.csproj");
            _storeWorkingDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            var parameters = $"store "
                + $" --framework netcoreapp2.0"
                + $" --configuration {Helpers.GetCurrentBuildConfiguration()}"
                + $" --runtime {GetRuntimeIdentifier()}"
                + $" --working-dir {_storeWorkingDir}"
                + $" --manifest {applicationProjFilePath}"
                + $" --preserve-working-dir";

            if (!CreateStoreInDefaultLocation)
            {
                parameters += $" --output {StoreDirectory}";
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

            hostProcess.StartAndCaptureOutAndErrToLogger("package-cache", _logger);

            hostProcess.WaitForExit();

            if (hostProcess.ExitCode != 0)
            {
                var message = $"dotnet store exited with exit code : {hostProcess.ExitCode}";
                throw new Exception(message);
            }
        }
    }
}
