using DbContextHelpers.Fixtures;

namespace AStar.Dev.Infrastructure.FilesDb.Tests.Integration;

/// <summary>
/// </summary>
public class FileDetailPagingExtensionsShould : IClassFixture<FilesContextFixture>
{
    private readonly FilesContextFixture filesContextFixture;

    public FileDetailPagingExtensionsShould(FilesContextFixture filesContextFixture) => this.filesContextFixture = filesContextFixture;
}
