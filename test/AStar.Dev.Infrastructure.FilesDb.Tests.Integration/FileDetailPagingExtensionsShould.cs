using AStar.Dev.Infrastructure.FilesDb.Data;
using DbContextHelpers.Fixtures;
using Shouldly;

namespace AStar.Dev.Infrastructure.FilesDb;

/// <summary>
/// </summary>
public class FileDetailPagingExtensionsShould : IClassFixture<FilesContextFixture>
{
    private readonly FilesContextFixture filesContextFixture;

    public FileDetailPagingExtensionsShould(FilesContextFixture filesContextFixture) => this.filesContextFixture = filesContextFixture;

    [Fact]
    public void ShouldReturnExpectedFirstPageOfTenResultsWithCorrectDetails()
    {
        var sut = filesContextFixture.SutWithFileDetails;

        var result = sut.FileDetails.GetPage(1, 10).ToList();

        result.Count.ShouldBe(10);
        result[0].FileName.Value.ShouldBe(@"\some\file.png");
        result[0].FileSize.ShouldBe(58887L);
    }

    [Fact]
    public void ShouldReturnExpectedThirdPageOfTwentyResultsWithCorrectDetails()
    {
        var sut = filesContextFixture.SutWithFileDetails;

        var result = sut.FileDetails.GetPage(28, 20).ToList();

        result.Count.ShouldBe(20);
        result[0].FileName.Value.ShouldBe(@"\some\file.jpg");
        result[0].FileSize.ShouldBe(20676L);
    }

    [Fact]
    public void ShouldReturnFirstPageOfResultsWhenPageRequestedIsZero()
    {
        var sut = filesContextFixture.SutWithFileDetails;

        var result = sut.FileDetails.GetPage(0, 20).ToList();

        result.Count.ShouldBe(20);
        result[0].FileName.Value.ShouldBe(@"\some\file.png");
        result[0].FileSize.ShouldBe(99512L);
    }

    [Fact]
    public void ShouldReturnExpectedFiftyResultsWhenMaxItemsIsExceeded()
    {
        var sut = filesContextFixture.SutWithFileDetails;

        var result = sut.FileDetails.GetPage(1, 51).ToList();

        result.Count.ShouldBe(50);
    }
}
