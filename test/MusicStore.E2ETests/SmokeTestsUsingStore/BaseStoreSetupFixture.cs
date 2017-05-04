using System;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Extensions.CommandLineUtils;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Testing;

namespace E2ETests
{
    public class BaseStoreSetupFixture : IDisposable
    {
        private readonly IDisposable _logToken;
        private readonly ILogger<BaseStoreSetupFixture> _logger;
        private readonly IDisposable _store;

        public BaseStoreSetupFixture(bool createInDefaultLocation, string loggerName, bool createStore)
        {
            if (!DynamicStore.IsEnabled() && !StaticStore.IsEnabled())
            {
                return;
            }

            CreateStoreInDefaultLocation = createInDefaultLocation;

            var testLog = AssemblyTestLog.ForAssembly(typeof(BaseStoreSetupFixture).Assembly);
            ILoggerFactory loggerFactory;
            _logToken = testLog.StartTestLog(null, loggerName, out loggerFactory, testName: loggerName);
            _logger = loggerFactory.CreateLogger<BaseStoreSetupFixture>();

            _logger.LogInformation(
                "Setting up store in the location: {location}",
                createInDefaultLocation ? "default" : "custom");

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

            StoreDirectory = storeDirectory;

            if (createStore)
            {
                _store = new DynamicStore(createInDefaultLocation, storeDirectory, _logger);
            }
            else
            {
                _store = new StaticStore(storeDirectory, _logger);
            }
        }

        public bool CreateStoreInDefaultLocation { get; }

        public string StoreDirectory { get; }

        public void Dispose()
        {
            if (_store != null)
            {
                _store.Dispose();
            }

            if (_logToken != null)
            {
                _logToken.Dispose();
            }
        }
    }
}
