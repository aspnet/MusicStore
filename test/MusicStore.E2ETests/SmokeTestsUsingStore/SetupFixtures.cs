namespace E2ETests
{
    public class StaticStoreInDefaultLocationSetupFixture : BaseStoreSetupFixture
    {
        public StaticStoreInDefaultLocationSetupFixture() :
            base(
                createInDefaultLocation: true,
                loggerName: nameof(StaticStoreInDefaultLocationSetupFixture),
                createStore: false)
        {
        }
    }

    public class DynamicStoreInDefaultLocationSetupFixture : BaseStoreSetupFixture
    {
        public DynamicStoreInDefaultLocationSetupFixture() :
            base(
                createInDefaultLocation: true,
                loggerName: nameof(DynamicStoreInDefaultLocationSetupFixture),
                createStore: true)
        {
        }
    }

    public class StaticStoreInCustomLocationSetupFixture : BaseStoreSetupFixture
    {
        public StaticStoreInCustomLocationSetupFixture() :
            base(
            createInDefaultLocation: false,
            loggerName: nameof(StaticStoreInCustomLocationSetupFixture),
            createStore: false)
        {
        }
    }

    public class DynamicStoreInCustomLocationSetupFixture : BaseStoreSetupFixture
    {
        public DynamicStoreInCustomLocationSetupFixture() :
            base(
                createInDefaultLocation: false,
                loggerName: nameof(DynamicStoreInCustomLocationSetupFixture),
                createStore: true)
        {
        }
    }
}
