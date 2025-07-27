using AStar.Dev.Infrastructure.FilesDb.Models;
using AStar.Dev.Utilities;
using Shouldly;

namespace AStar.Dev.Infrastructure.FilesDb.Tests.Unit.Models;

public class FileNamePartShould
{
    [Fact]
    public void ContainTheExpectedProperties()
        => new FileNamePart { FileClassifications = new List<FileClassification> { new()  { Id = 1 } } }
           .ToJson()
           .ShouldMatchApproved();
}
