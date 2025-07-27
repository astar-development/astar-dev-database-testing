using AStar.Dev.Infrastructure.FilesDb.Models;
using AStar.Dev.Utilities;
using Shouldly;

namespace AStar.Dev.Infrastructure.FilesDb.Tests.Unit.Models;

public class FileNameShould
{
    [Fact]
    public void ContainTheExpectedProperties()
        => new FileName { Value = "mock-file-name" }
           .ToJson()
           .ShouldMatchApproved();
}
