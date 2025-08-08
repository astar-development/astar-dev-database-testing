using AStar.Dev.Infrastructure.FilesDb.Data;
using AStar.Dev.Infrastructure.FilesDb.Models;
using DbContextHelpers.Fixtures;
using Shouldly;

namespace AStar.Dev.Infrastructure.FilesDb;

public class FileDetailDirectoryNameExtensionsShould : IClassFixture<FilesContextFixture>
{
    private readonly FilesContextFixture filesContextFixture;

    public FileDetailDirectoryNameExtensionsShould(FilesContextFixture filesContextFixture) => this.filesContextFixture = filesContextFixture;

    [Fact]
    public void ShouldReturnExpectedFileDetailsWhenDirectoryNameSpecifiedAndRecursionIsFalse()
    {
        var searchDirectory = new DirectoryName(@"\one-level\");

        var sut = filesContextFixture.SutWithFileDetails;

        var result = sut.FileDetails.WhereDirectoryNameMatches(searchDirectory.Value, false).ToList();

        result.Count.ShouldBe(457);
    }

    [Fact]
    public void ShouldReturnExpectedFileDetailsWhenDirectoryNameSpecifiedAndRecursionIsTrue()
    {
        var searchDirectory = new DirectoryName(@"\with");

        var sut = filesContextFixture.SutWithFileDetails;

        var result = sut.FileDetails.WhereDirectoryNameMatches(searchDirectory.Value, true).ToList();

        result.Count.ShouldBe(1084);
    }
}
