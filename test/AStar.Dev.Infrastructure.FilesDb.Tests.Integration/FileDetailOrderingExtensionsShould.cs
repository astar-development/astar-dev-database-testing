using DbContextHelpers.Fixtures;

namespace AStar.Dev.Infrastructure.FilesDb.Tests.Integration;

/// <summary>
/// </summary>
public class FileDetailOrderingExtensionsShould : IClassFixture<FilesContextFixture>
{
    private readonly FilesContextFixture filesContextFixture;

    public FileDetailOrderingExtensionsShould(FilesContextFixture filesContextFixture) => this.filesContextFixture = filesContextFixture;
}
