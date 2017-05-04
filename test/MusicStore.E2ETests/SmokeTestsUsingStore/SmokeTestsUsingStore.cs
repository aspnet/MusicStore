using System.Threading.Tasks;
using Microsoft.AspNetCore.Server.IntegrationTesting;
using Microsoft.AspNetCore.Testing.xunit;
using Xunit;
using Xunit.Abstractions;

namespace E2ETests
{
    public class SmokeTestsUsingDynamicStoreInDefaultLocation : IClassFixture<DynamicStoreInDefaultLocationSetupFixture>
    {
        private readonly DynamicStoreInDefaultLocationSetupFixture _testFixture;
        private readonly ITestOutputHelper _output;

        public SmokeTestsUsingDynamicStoreInDefaultLocation(
            DynamicStoreInDefaultLocationSetupFixture testFixure,
            ITestOutputHelper output)
        {
            _testFixture = testFixure;
            _output = output;
        }

        [SkipIfEnvironmentVariableNotEnabled(BaseStoreSetupFixture.AspNetCoreStoreEnvironmentVariableName)]
        [ConditionalTheory]
        [Trait("smoketests", "packagecache")]
        [Trait("smoketests", "default-packagecache")]
        [InlineData(ServerType.Kestrel)]
        [InlineData(ServerType.WebListener)]
        public async Task DefaultLocation(ServerType serverType)
        {
            var tests = new SmokeTestsUsingStoreHelper(_output);
            await tests.SmokeTestSuite(
                serverType,
                _testFixture.CreateStoreInDefaultLocation,
                _testFixture.StoreDirectory);
        }
    }

    public class SmokeTestsUsingDynamicStoreInCustomLocation : IClassFixture<DynamicStoreInCustomLocationSetupFixture>
    {
        private readonly DynamicStoreInCustomLocationSetupFixture _testFixture;
        private readonly ITestOutputHelper _output;

        public SmokeTestsUsingDynamicStoreInCustomLocation(
            DynamicStoreInCustomLocationSetupFixture testFixure,
            ITestOutputHelper output)
        {
            _testFixture = testFixure;
            _output = output;
        }

        [SkipIfEnvironmentVariableNotEnabled(BaseStoreSetupFixture.AspNetCoreStoreEnvironmentVariableName)]
        [ConditionalTheory]
        [Trait("smoketests", "packagecache")]
        [Trait("smoketests", "custom-packagecache")]
        [InlineData(ServerType.Kestrel)]
        [InlineData(ServerType.WebListener)]
        public async Task CustomLocation(ServerType serverType)
        {
            var tests = new SmokeTestsUsingStoreHelper(_output);
            await tests.SmokeTestSuite(
                serverType,
                _testFixture.CreateStoreInDefaultLocation,
                _testFixture.StoreDirectory);
        }
    }

    public class SmokeTestsUsingStaticStoreInDefaultLocation : IClassFixture<StaticStoreInDefaultLocationSetupFixture>
    {
        private readonly StaticStoreInDefaultLocationSetupFixture _testFixture;
        private readonly ITestOutputHelper _output;

        public SmokeTestsUsingStaticStoreInDefaultLocation(
            StaticStoreInDefaultLocationSetupFixture testFixure,
            ITestOutputHelper output)
        {
            _testFixture = testFixure;
            _output = output;
        }

        [OSSkipCondition(OperatingSystems.Linux)]
        [OSSkipCondition(OperatingSystems.MacOSX)]
        [SkipIfEnvironmentVariableNotEnabled(BaseStoreSetupFixture.AspNetCoreStoreEnvironmentVariableName)]
        [ConditionalTheory]
        [Trait("smoketests", "packagecache")]
        [Trait("smoketests", "default-packagecache")]
        [InlineData(ServerType.Kestrel)]
        [InlineData(ServerType.WebListener)]
        public async Task DefaultLocation(ServerType serverType)
        {
            var tests = new SmokeTestsUsingStoreHelper(_output);
            await tests.SmokeTestSuite(
                serverType,
                _testFixture.CreateStoreInDefaultLocation,
                _testFixture.StoreDirectory);
        }
    }

    public class SmokeTestsUsingStaticStoreInCustomLocation : IClassFixture<StaticStoreInCustomLocationSetupFixture>
    {
        private readonly StaticStoreInCustomLocationSetupFixture _testFixture;
        private readonly ITestOutputHelper _output;

        public SmokeTestsUsingStaticStoreInCustomLocation(
            StaticStoreInCustomLocationSetupFixture testFixure,
            ITestOutputHelper output)
        {
            _testFixture = testFixure;
            _output = output;
        }

        [OSSkipCondition(OperatingSystems.Linux)]
        [OSSkipCondition(OperatingSystems.MacOSX)]
        [SkipIfEnvironmentVariableNotEnabled(BaseStoreSetupFixture.AspNetCoreStoreEnvironmentVariableName)]
        [ConditionalTheory]
        [Trait("smoketests", "packagecache")]
        [Trait("smoketests", "custom-packagecache")]
        [InlineData(ServerType.Kestrel)]
        [InlineData(ServerType.WebListener)]
        public async Task CustomLocation(ServerType serverType)
        {
            var tests = new SmokeTestsUsingStoreHelper(_output);
            await tests.SmokeTestSuite(
                serverType,
                _testFixture.CreateStoreInDefaultLocation,
                _testFixture.StoreDirectory);
        }
    }
}