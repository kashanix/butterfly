using Xunit;

namespace Application.IntegrationTests.Fixtures
{
    [CollectionDefinition("Application")]
    public class IntegrationTestsCollection : ICollectionFixture<TestHostFixture> { }
}
