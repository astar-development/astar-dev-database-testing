using AStar.Dev.Infrastructure.FilesDb.Data;
using DbContextHelpers.Fixtures;
using Shouldly;

namespace AStar.Dev.Infrastructure.FilesDb.Tests.Integration;

/// <summary>
/// </summary>
public class FileDetailTextContainsExtensionsShould (FilesContextFixture filesContextFixture) : IClassFixture<FilesContextFixture>
{
    [Fact]
    public void ReturnTheExpectedFilesMatchingTheSuppliedTextWhenExistsInTheDirectoryNameOnly()
    {
        var sut = filesContextFixture.Sut;

        var result = sut.FileDetails.SelectFilesMatching("with");

        result.Count().ShouldBe(1621);
    }

    [Fact]
    public void ReturnTheExpectedFilesMatchingTheSuppliedTextWhenExistsInTheFileNameOnly()
    {
        var sut = filesContextFixture.Sut;

        var result = sut.FileDetails.SelectFilesMatching("file.gif");

        result.Count().ShouldBe(693);
    }

    [Fact]
    public void ReturnTheExpectedFilesMatchingTheSuppliedTextWhenExistsInTheDirectoryNameAndTheFileName()
    {
        var sut = filesContextFixture.Sut;

        var result = sut.FileDetails.SelectFilesMatching("some");

        result.Count().ShouldBe(2999);
    }

    [Fact]
    public void ReturnNoFilesWhenTheSuppliedTextDoesntExistsInTheDirectoryNameOrTheFileName()
    {
        var sut = filesContextFixture.Sut;

        var result = sut.FileDetails.SelectFilesMatching("search-text that wont match");

        result.Count().ShouldBe(0);
    }

    [Fact]
    public void ReturnAllFilesWhenTheSuppliedTextIsNull()
    {
        var sut = filesContextFixture.Sut;

        var result = sut.FileDetails.SelectFilesMatching(null);

        result.Count().ShouldBe(3000);
    }
}
