using DbContextHelpers.Fixtures;

namespace AStar.Dev.Infrastructure.FilesDb.Tests.Integration;

/// <summary>
/// </summary>
public class FileDetailDeletionStatusExtensionsShould : IClassFixture<FilesContextFixture>
{
    private readonly FilesContextFixture filesContextFixture;

    public FileDetailDeletionStatusExtensionsShould(FilesContextFixture filesContextFixture) => this.filesContextFixture = filesContextFixture;
}
