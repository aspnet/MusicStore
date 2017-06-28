using System.Threading.Tasks;
using Microsoft.AspNetCore.Server.IntegrationTesting;
using Microsoft.AspNetCore.Testing.xunit;
using Xunit;
using Xunit.Abstractions;

namespace E2ETests
{
    public class SmokeTestsUsingDefaultLocation : IClassFixture<StoreSetupFixture>
    {
        private readonly StoreSetupFixture _testFixture;
        private readonly ITestOutputHelper _output;

        public SmokeTestsUsingDefaultLocation(
            StoreSetupFixture testFixure,
            ITestOutputHelper output)
        {
            _testFixture = testFixure;
            _output = output;
        }

        [EnvironmentVariableSkipCondition(Store.MusicStoreAspNetCoreStoreFeed, null, SkipOnMatch = false)]
        [ConditionalFact]
        [Trait("smoketests", "usestore1")]
        public async Task DefaultLocation_Kestrel()
        {
            var tests = new SmokeTestsUsingStoreHelper(_output);
            await tests.SmokeTestSuite(
                ServerType.Kestrel,
                _testFixture.StoreDirectory);
        }

        [OSSkipCondition(OperatingSystems.Linux)]
        [OSSkipCondition(OperatingSystems.MacOSX)]
        [EnvironmentVariableSkipCondition(Store.MusicStoreAspNetCoreStoreFeed, null, SkipOnMatch = false)]
        [ConditionalFact]
        [Trait("smoketests", "usestore")]
        public async Task DefaultLocation_WebListener()
        {
            var tests = new SmokeTestsUsingStoreHelper(_output);
            await tests.SmokeTestSuite(
                ServerType.WebListener,
                _testFixture.StoreDirectory);
        }
    }
}