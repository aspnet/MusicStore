using System.Threading.Tasks;
using Microsoft.AspNetCore.Server.IntegrationTesting;
using Microsoft.AspNetCore.Testing.xunit;
using Xunit;
using Xunit.Abstractions;

namespace E2ETests
{
    [Trait("E2Etests", "Smoke")]
    public class SmokeTests_X64
    {
        private readonly SmokeTestRunner _smokeTestRunner;

        public SmokeTests_X64(ITestOutputHelper output)
        {
            _smokeTestRunner = new SmokeTestRunner(output);
        }
#if !NETCOREAPP2_0 // Avoid running CLR based tests once on netcoreapp2.0 and netcoreapp2.1 each
        [ConditionalFact]
        [OSSkipCondition(OperatingSystems.Linux | OperatingSystems.MacOSX)]
        public Task SmokeTests_X64_WebListener_Clr()
        {
            return _smokeTestRunner.SmokeTestSuite(ServerType.WebListener, RuntimeFlavor.Clr, RuntimeArchitecture.x64, ApplicationType.Portable);
        }
#endif
        [ConditionalFact]
        [OSSkipCondition(OperatingSystems.Linux | OperatingSystems.MacOSX)]
        public Task SmokeTests_X64_WebListener_CoreClr_Portable()
        {
            return _smokeTestRunner.SmokeTestSuite(ServerType.WebListener, RuntimeFlavor.CoreClr, RuntimeArchitecture.x64, ApplicationType.Portable);
        }

        [ConditionalFact]
        [OSSkipCondition(OperatingSystems.Linux | OperatingSystems.MacOSX)]
        public Task SmokeTests_X64_WebListener_CoreClr_Standalone()
        {
            return _smokeTestRunner.SmokeTestSuite(ServerType.WebListener, RuntimeFlavor.CoreClr, RuntimeArchitecture.x64, ApplicationType.Standalone);
        }
#if !NETCOREAPP2_0 // Avoid running CLR based tests once on netcoreapp2.0 and netcoreapp2.1 each
        [ConditionalFact(Skip = "https://github.com/aspnet/websdk/pull/322")]
        [OSSkipCondition(OperatingSystems.Linux | OperatingSystems.MacOSX)]
        public Task SmokeTests_X64_IISExpress_Clr()
        {
            return _smokeTestRunner.SmokeTestSuite(ServerType.IISExpress, RuntimeFlavor.Clr, RuntimeArchitecture.x64, ApplicationType.Portable);
        }
#endif
        [ConditionalFact]
        [OSSkipCondition(OperatingSystems.Linux | OperatingSystems.MacOSX)]
        public Task SmokeTests_X64_IISExpress_CoreClr_OutOfProcess_V1_Portable()
        {
            return _smokeTestRunner.SmokeTestSuite(ServerType.IISExpress, RuntimeFlavor.CoreClr, RuntimeArchitecture.x64, ApplicationType.Portable, HostingModel.OutOfProcess, additionalPublishParameters: "/p:ANCMVersion=V1");
        }

        [ConditionalFact]
        [OSSkipCondition(OperatingSystems.Linux | OperatingSystems.MacOSX)]
        public Task SmokeTests_X64_IISExpress_CoreClr_OutOfProcess_V1_Standalone()
        {
            return _smokeTestRunner.SmokeTestSuite(ServerType.IISExpress, RuntimeFlavor.CoreClr, RuntimeArchitecture.x64, ApplicationType.Standalone, HostingModel.OutOfProcess, additionalPublishParameters: "/p:ANCMVersion=V1");
        }

        [ConditionalFact]
        [OSSkipCondition(OperatingSystems.Linux | OperatingSystems.MacOSX)]
        public Task SmokeTests_X64_IISExpress_CoreClr_OutOfProcess_V2_Portable()
        {
            return _smokeTestRunner.SmokeTestSuite(ServerType.IISExpress, RuntimeFlavor.CoreClr, RuntimeArchitecture.x64, ApplicationType.Portable, HostingModel.OutOfProcess, additionalPublishParameters: "/p:ANCMVersion=V2");
        }

        [ConditionalFact]
        [OSSkipCondition(OperatingSystems.Linux | OperatingSystems.MacOSX)]
        public Task SmokeTests_X64_IISExpress_CoreClr_OutOfProcess_V2_Standalone()
        {
            return _smokeTestRunner.SmokeTestSuite(ServerType.IISExpress, RuntimeFlavor.CoreClr, RuntimeArchitecture.x64, ApplicationType.Standalone, HostingModel.OutOfProcess, additionalPublishParameters: "/p:ANCMVersion=V2");
        }

        [ConditionalFact]
        [OSSkipCondition(OperatingSystems.Linux | OperatingSystems.MacOSX)]
        public Task SmokeTests_X64_IISExpress_CoreClr_InProcess_Portable()
        {
            return _smokeTestRunner.SmokeTestSuite(ServerType.IISExpress, RuntimeFlavor.CoreClr, RuntimeArchitecture.x64, ApplicationType.Portable, HostingModel.InProcess, additionalPublishParameters: "/p:ANCMVersion=V2");
        }

        [ConditionalFact]
        [OSSkipCondition(OperatingSystems.Linux | OperatingSystems.MacOSX)]
        public Task SmokeTests_X64_IISExpress_CoreClr_InProcess_Standalone()
        {
            return _smokeTestRunner.SmokeTestSuite(ServerType.IISExpress, RuntimeFlavor.CoreClr, RuntimeArchitecture.x64, ApplicationType.Standalone, HostingModel.InProcess, additionalPublishParameters: "/p:ANCMVersion=V2");
        }
#if !NETCOREAPP2_0 // Avoid running CLR based tests once on netcoreapp2.0 and netcoreapp2.1 each
        [ConditionalFact]
        [OSSkipCondition(OperatingSystems.Linux | OperatingSystems.MacOSX)]
        public Task SmokeTests_X64_Kestrel_Clr()
        {
            return _smokeTestRunner.SmokeTestSuite(ServerType.Kestrel, RuntimeFlavor.Clr, RuntimeArchitecture.x64, ApplicationType.Portable);
        }
#endif
        [Fact]
        public Task SmokeTests_X64_Kestrel_CoreClr_Portable()
        {
            return _smokeTestRunner.SmokeTestSuite(ServerType.Kestrel, RuntimeFlavor.CoreClr, RuntimeArchitecture.x64, ApplicationType.Portable);
        }

        [Fact]
        public Task SmokeTests_X64_Kestrel_CoreClr_Standalone()
        {
            return _smokeTestRunner.SmokeTestSuite(ServerType.Kestrel, RuntimeFlavor.CoreClr, RuntimeArchitecture.x64, ApplicationType.Standalone);
        }
    }
}
