using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Server.IntegrationTesting;
using Microsoft.AspNetCore.Testing.xunit;
using Microsoft.Extensions.CommandLineUtils;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Testing;
using Xunit;
using Xunit.Abstractions;

namespace E2ETests
{
    public class SmokeTestsUsingDefaultPackageCacheLocation : IClassFixture<DefaultLocationPackageCacheSetupTestFixture>
    {
        private readonly DefaultLocationPackageCacheSetupTestFixture _testFixture;
        private readonly ITestOutputHelper _output;

        public SmokeTestsUsingDefaultPackageCacheLocation(
            DefaultLocationPackageCacheSetupTestFixture testFixure,
            ITestOutputHelper output)
        {
            _testFixture = testFixure;
            _output = output;
        }

        // [SkipIfEnvironmentVariableNotEnabled(PackageCacheSetupTestFixture.UsePackageCacheEnvironmentVariableName")]
        // [ConditionalFact, Trait("smoketests", "default-packagecache")]
        // [OSSkipCondition(OperatingSystems.Linux)]
        // [OSSkipCondition(OperatingSystems.MacOSX)]
        // public async Task DefaultLocation_IISExpress()
        // {
        //     var tests = new SmokeTestsUsingPackageCache(_output);
        //     await tests.SmokeTestSuite(
        //         ServerType.IISExpress,
        //         _testFixture.CreateCacheInDefaultLocation,
        //         _testFixture.StoreDirectory);
        // }

        [SkipIfEnvironmentVariableNotEnabled(PackageCacheSetupTestFixture.UsePackageCacheEnvironmentVariableName)]
        [ConditionalTheory]
        [Trait("smoketests", "packagecache")]
        [Trait("smoketests", "default-packagecache")]
        [InlineData(ServerType.Kestrel)]
        [InlineData(ServerType.WebListener)]
        public async Task DefaultLocation(ServerType serverType)
        {
            var tests = new SmokeTestsUsingPackageCache(_output);
            await tests.SmokeTestSuite(
                serverType,
                _testFixture.CreateCacheInDefaultLocation,
                _testFixture.StoreDirectory);
        }
    }

    public class SmokeTestsUsingCustomPackageCacheLocation : IClassFixture<CustomLocationPackageCacheSetupTestFixture>
    {
        private readonly CustomLocationPackageCacheSetupTestFixture _testFixture;
        private readonly ITestOutputHelper _output;

        public SmokeTestsUsingCustomPackageCacheLocation(
            CustomLocationPackageCacheSetupTestFixture testFixure,
            ITestOutputHelper output)
        {
            _testFixture = testFixure;
            _output = output;
        }

        // [SkipIfEnvironmentVariableNotEnabled(PackageCacheSetupTestFixture.UsePackageCacheEnvironmentVariableName)]
        // [ConditionalFact, Trait("smoketests", "custom-packagecache")]
        // [OSSkipCondition(OperatingSystems.Linux)]
        // [OSSkipCondition(OperatingSystems.MacOSX)]
        // public async Task CustomLocation_IISExpress()
        // {
        //     var tests = new SmokeTestsUsingPackageCache(_output);
        //     await tests.SmokeTestSuite(
        //         ServerType.IISExpress,
        //         _testFixture.CreateCacheInDefaultLocation,
        //         _testFixture.StoreDirectory);
        // }

        [SkipIfEnvironmentVariableNotEnabled(PackageCacheSetupTestFixture.UsePackageCacheEnvironmentVariableName)]
        [ConditionalTheory]
        [Trait("smoketests", "packagecache")]
        [Trait("smoketests", "custom-packagecache")]
        [InlineData(ServerType.Kestrel)]
        [InlineData(ServerType.WebListener)]
        public async Task CustomLocation(ServerType serverType)
        {
            var tests = new SmokeTestsUsingPackageCache(_output);
            await tests.SmokeTestSuite(
                serverType,
                _testFixture.CreateCacheInDefaultLocation,
                _testFixture.StoreDirectory);
        }
    }

    public class DefaultLocationPackageCacheSetupTestFixture : PackageCacheSetupTestFixture
    {
        public DefaultLocationPackageCacheSetupTestFixture() :
            base(createInDefaultLocation: true, loggerName: nameof(DefaultLocationPackageCacheSetupTestFixture))
        {
        }
    }

    public class CustomLocationPackageCacheSetupTestFixture : PackageCacheSetupTestFixture
    {
        public CustomLocationPackageCacheSetupTestFixture() :
            base(createInDefaultLocation: false, loggerName: nameof(CustomLocationPackageCacheSetupTestFixture))
        {
        }
    }

    public class PackageCacheSetupTestFixture : IDisposable
    {
        public const string UsePackageCacheEnvironmentVariableName = "MusicStore_UsePackageCache";

        private ILoggerFactory _loggerFactory;
        private readonly IDisposable _logToken;
        private readonly ILogger<PackageCacheSetupTestFixture> _logger;
        private readonly string _packageCacheWorkingDir;

        public PackageCacheSetupTestFixture(bool createInDefaultLocation, string loggerName)
        {
            var usePackageCache = Environment.GetEnvironmentVariable(UsePackageCacheEnvironmentVariableName);
            if (usePackageCache == null || string.Equals(usePackageCache, "false", StringComparison.OrdinalIgnoreCase))
            {
                return;
            }

            var testLog = AssemblyTestLog.ForAssembly(typeof(PackageCacheSetupTestFixture).Assembly);
            _logToken = testLog.StartTestLog(null, loggerName, out _loggerFactory, testName: loggerName);
            _logger = _loggerFactory.CreateLogger<PackageCacheSetupTestFixture>();

            CreateCacheInDefaultLocation = createInDefaultLocation;

            _logger.LogInformation(
                "Setting up package cache in the location: {location}",
                CreateCacheInDefaultLocation ? "default" : "custom");

            var applicationPath = Helpers.GetApplicationPath(ApplicationType.Portable);
            var applicationProjFilePath = Path.Combine(applicationPath, "MusicStore.csproj");
            _packageCacheWorkingDir = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
            var parameters = $"store "
                + $" --framework netcoreapp2.0"
                + $" --configuration {Helpers.GetCurrentBuildConfiguration()}"
                + $" --runtime {GetRuntimeIdentifier()}"
                + $" --working-dir {_packageCacheWorkingDir}"
                + $" --manifest {applicationProjFilePath}"
                + $" --preserve-working-dir";

            if (CreateCacheInDefaultLocation)
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

        public bool CreateCacheInDefaultLocation { get; set; }

        public string StoreDirectory { get; }

        public void Dispose()
        {
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
                        () => Directory.Delete(_packageCacheWorkingDir, recursive: true),
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
    }

    public class SmokeTestsUsingPackageCache : LoggedTest
    {
        public SmokeTestsUsingPackageCache(ITestOutputHelper output) : base(output)
        {
        }

        public async Task SmokeTestSuite(ServerType serverType, bool isCacheInDefaultLocation, string storeDirectory)
        {
            var targetFramework = "netcoreapp2.0";
            var testName = $"SmokeTestsUsingPackageCache_{serverType}";
            using (StartLog(out var loggerFactory, testName))
            {
                var logger = loggerFactory.CreateLogger(nameof(SmokeTestsUsingPackageCache));
                var musicStoreDbName = DbUtils.GetUniqueName();

                var deploymentParameters = new DeploymentParameters(
                    Helpers.GetApplicationPath(ApplicationType.Portable), serverType, RuntimeFlavor.CoreClr, RuntimeArchitecture.x64)
                {
                    EnvironmentName = "SocialTesting",
                    ServerConfigTemplateContent = (serverType == ServerType.IISExpress) ? File.ReadAllText("Http.config") : null,
                    SiteName = "MusicStoreTestSiteUsingPackageCache",
                    PublishApplicationBeforeDeployment = true,
                    PreservePublishedApplicationForDebugging = Helpers.PreservePublishedApplicationForDebugging,
                    TargetFramework = targetFramework,
                    Configuration = Helpers.GetCurrentBuildConfiguration(),
                    ApplicationType = ApplicationType.Portable,
                    UserAdditionalCleanup = parameters =>
                    {
                        DbUtils.DropDatabase(musicStoreDbName, logger);
                    }
                };

                // Override the connection strings using environment based configuration
                deploymentParameters.EnvironmentVariables
                    .Add(new KeyValuePair<string, string>(
                        MusicStoreConfig.ConnectionStringKey,
                        DbUtils.CreateConnectionString(musicStoreDbName)));

                string artifactXml = null;
                if (isCacheInDefaultLocation)
                {
                    artifactXml = Path.Combine(storeDirectory, targetFramework, "artifact.xml");
                }
                else
                {
                    deploymentParameters.EnvironmentVariables.Add(
                        new KeyValuePair<string, string>("DOTNET_SHARED_STORE", storeDirectory));

                    artifactXml = Path.Combine(storeDirectory, "x64", targetFramework, "artifact.xml");
                }

                deploymentParameters.AdditionalPublishParameters = $" --manifest {artifactXml}";

                using (var deployer = ApplicationDeployerFactory.Create(deploymentParameters, loggerFactory))
                {
                    var deploymentResult = await deployer.DeployAsync();

                    var mvcCoreDllPath = Path.Combine(deploymentResult.ContentRoot, "Microsoft.AspNetCore.Mvc.Core.dll");
                    var fileInfo = new FileInfo(mvcCoreDllPath);
                    Assert.False(
                        File.Exists(mvcCoreDllPath),
                        $"The file '{fileInfo.Name}.{fileInfo.Extension}' was not expected to be present in the publish directory");

                    await SmokeTestHelper.RunTestsAsync(deploymentResult, logger);
                }
            }
        }
    }
}