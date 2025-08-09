using Xunit;

namespace DbContextHelpers.Fixtures;

[CollectionDefinition(nameof(SharedIntegrationCollection))]
public class SharedIntegrationCollection : ICollectionFixture<FilesContextFixture>
{
    // This class has no code, and is never created. Its purpose is simply
    // to be the place to apply [CollectionDefinition] and all the
    // ICollectionFixture<> interfaces.
}
