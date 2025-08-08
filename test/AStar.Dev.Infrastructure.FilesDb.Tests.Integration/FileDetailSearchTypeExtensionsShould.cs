using AStar.Dev.Infrastructure.FilesDb.Data;
using AStar.Dev.Infrastructure.FilesDb.Models;
using DbContextHelpers.Fixtures;
using Shouldly;

namespace AStar.Dev.Infrastructure.FilesDb;

/// <summary>
/// </summary>
public class FileDetailSearchTypeExtensionsShould : IClassFixture<FilesContextFixture>
{
    private readonly FilesContextFixture filesContextFixture;

    public FileDetailSearchTypeExtensionsShould(FilesContextFixture filesContextFixture) => this.filesContextFixture = filesContextFixture;

    [Fact]
    public void ShouldReturnExpectedFileDetailsWhenSearchTypeIsSetToAll()
    {
        var sut = filesContextFixture.SutWithFileDetails;

        var result = sut.FileDetails.OfSearchType(SearchType.All).ToList();

        result.Count.ShouldBe(2000);
        result[0].FileName.Value.ShouldBe("file.txt");
        result[0].FileSize.ShouldBe(91801L);
    }

    [Fact]
    public void ShouldReturnExpectedFileDetailsWhenSearchTypeIsSetToImages()
    {
        var sut = filesContextFixture.SutWithFileDetails;

        var result = sut.FileDetails.OfSearchType(SearchType.Images).ToList();

        result.Count.ShouldBe(1541);
        result[0].FileName.Value.ShouldBe(@"\some\file.gif");
        result[0].FileSize.ShouldBe(22081L);
    }

    [Fact]
    public void ShouldReturnExpectedFileDetailsWhenSearchTypeIsSetToDuplicateImages()
    {
        var sut = filesContextFixture.SutWithFileDetails;

        var result = sut.FileDetails.OfSearchType(SearchType.DuplicateImages).ToList();

        result.Count.ShouldBe(5678);
        result[0].FileName.Value.ShouldBe(@"\some\file.bmp");
        result[0].FileSize.ShouldBe(91451L);
    }

    [Fact]
    public void ShouldReturnExpectedFileDetailsWhenSearchTypeIsSetToDuplicates()
    {
        var sut = filesContextFixture.SutWithFileDetails;

        var result = sut.FileDetails.OfSearchType(SearchType.Duplicates).ToList();

        result.Count.ShouldBe(1234);
        result[0].FileName.Value.ShouldBe(@"\some\file.bmp");
        result[0].FileSize.ShouldBe(91451L);
    }
}
