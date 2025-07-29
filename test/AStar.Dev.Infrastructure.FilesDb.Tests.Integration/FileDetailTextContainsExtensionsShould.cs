using AStar.Dev.Infrastructure.FilesDb.Data;
using DbContextHelpers.Fixtures;
using Shouldly;

namespace AStar.Dev.Infrastructure.FilesDb.Tests.Integration;

/// <summary>
/// </summary>
public class FileDetailTextContainsExtensionsShould : IClassFixture<FilesContextFixture>
{
    private readonly FilesContextFixture filesContextFixture;

    public FileDetailTextContainsExtensionsShould(FilesContextFixture filesContextFixture) => this.filesContextFixture = filesContextFixture;

    [Fact]
    public void ReturnTheExpectedFilesMatchingTheSuppliedTextWhenExistsInTheDirectoryNameOnly()
    {
        var sut = filesContextFixture.SutWithFileDetails;

        var result = sut.FileDetails.SelectFilesMatching("with");

        result.Count().ShouldBe(1084);
    }

    [Fact]
    public void ReturnTheExpectedFilesMatchingTheSuppliedTextWhenExistsInTheFileNameOnly()
    {
        var sut = filesContextFixture.SutWithFileDetails;

        var result = sut.FileDetails.SelectFilesMatching("file.gif");

        result.Count().ShouldBe(457);
    }

    [Fact]
    public void ReturnTheExpectedFilesMatchingTheSuppliedTextWhenExistsInTheDirectoryNameAndTheFileName()
    {
        var sut = filesContextFixture.SutWithFileDetails;

        var result = sut.FileDetails.SelectFilesMatching("some");

        result.Count().ShouldBe(1999);
    }

    [Fact]
    public void ReturnNoFilesWhenTheSuppliedTextDoesntExistsInTheDirectoryNameOrTheFileName()
    {
        var sut = filesContextFixture.SutWithFileDetails;

        var result = sut.FileDetails.SelectFilesMatching("search-text that wont match");

        result.Count().ShouldBe(0);
    }

    [Fact]
    public void ReturnAllFilesWhenTheSuppliedTextIsNull()
    {
        var sut = filesContextFixture.SutWithFileDetails;

        var result = sut.FileDetails.SelectFilesMatching(null);

        result.Count().ShouldBe(2000);
    }
}
