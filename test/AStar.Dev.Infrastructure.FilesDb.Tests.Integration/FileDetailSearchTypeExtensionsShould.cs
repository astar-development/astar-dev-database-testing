using DbContextHelpers.Fixtures;

namespace AStar.Dev.Infrastructure.FilesDb.Tests.Integration;

/// <summary>
/// </summary>
public class FileDetailSearchTypeExtensionsShould : IClassFixture<FilesContextFixture>
{
    private readonly FilesContextFixture filesContextFixture;

    public FileDetailSearchTypeExtensionsShould(FilesContextFixture filesContextFixture) => this.filesContextFixture = filesContextFixture;
}
