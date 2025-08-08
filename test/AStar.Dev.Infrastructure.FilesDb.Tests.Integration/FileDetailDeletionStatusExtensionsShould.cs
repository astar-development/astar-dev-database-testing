using AStar.Dev.Infrastructure.FilesDb.Data;
using DbContextHelpers.Fixtures;
using Shouldly;

namespace AStar.Dev.Infrastructure.FilesDb;

/// <summary>
/// </summary>
public class FileDetailDeletionStatusExtensionsShould : IClassFixture<FilesContextFixture>
{
    private readonly FilesContextFixture filesContextFixture;

    public FileDetailDeletionStatusExtensionsShould(FilesContextFixture filesContextFixture) => this.filesContextFixture = filesContextFixture;

    [Fact]
    public void ShouldReturnExpectedFileDetailsWhenIncludeDeletedOrDeletePendingIsFalse()
    {
        var sut = filesContextFixture.SutWithFileDetails;

        var result = sut.FileDetails.IncludeDeletedOrDeletePending(false).ToList();

        result.Count.ShouldBe(1734);
    }

    [Fact]
    public void ShouldReturnExpectedFileDetailsWhenIncludeDeletedOrDeletePendingIsTrue()
    {
        var sut = filesContextFixture.SutWithFileDetails;

        var result = sut.FileDetails.IncludeDeletedOrDeletePending(true).ToList();

        result.Count.ShouldBe(2000);
    }
}
