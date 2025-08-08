using AStar.Dev.Infrastructure.FilesDb.Data;
using AStar.Dev.Infrastructure.FilesDb.Models;
using DbContextHelpers.Fixtures;
using Shouldly;

namespace AStar.Dev.Infrastructure.FilesDb;

/// <summary>
/// </summary>
public class FileDetailOrderingExtensionsShould : IClassFixture<FilesContextFixture>
{
    private readonly FilesContextFixture filesContextFixture;

    public FileDetailOrderingExtensionsShould(FilesContextFixture filesContextFixture) => this.filesContextFixture = filesContextFixture;

    [Fact]
    public void ShouldReturnExpectedFileDetailsOrderedByNameAscending()
    {
        var sut = filesContextFixture.SutWithFileDetails;

        var result = sut.FileDetails.OrderResultsBy(SortOrder.NameAscending).ToList();

        result.Count.ShouldBe(2000);
        result[0].FileName.Value.ShouldBe(@"\some\file.bmp");
        result[0].FileSize.ShouldBe(91451L);
    }

    [Fact]
    public void ShouldReturnExpectedFileDetailsOrderedByNameDescending()
    {
        var sut = filesContextFixture.SutWithFileDetails;

        var result = sut.FileDetails.OrderResultsBy(SortOrder.NameDescending).ToList();

        result.Count.ShouldBe(2000);
        result[0].FileName.Value.ShouldBe(@"file.txt");
        result[0].FileSize.ShouldBe(91801L);
    }

    [Fact]
    public void ShouldReturnExpectedFileDetailsOrderedBySizeAscending()
    {
        var sut = filesContextFixture.SutWithFileDetails;

        var result = sut.FileDetails.OrderResultsBy(SortOrder.SizeAscending).ToList();

        result.Count.ShouldBe(2000);
        result[0].FileName.Value.ShouldBe(@"\some\file.png");
        result[0].FileSize.ShouldBe(20024L);
    }

    [Fact]
    public void ShouldReturnExpectedFileDetailsOrderedBySizeDescending()
    {
        var sut = filesContextFixture.SutWithFileDetails;

        var result = sut.FileDetails.OrderResultsBy(SortOrder.SizeDescending).ToList();

        result.Count.ShouldBe(2000);
        result[0].FileName.Value.ShouldBe(@"\some\file.txt");
        result[0].FileSize.ShouldBe(99889L);
    }
}
