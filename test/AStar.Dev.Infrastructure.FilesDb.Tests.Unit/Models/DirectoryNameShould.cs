using AStar.Dev.Infrastructure.FilesDb.Models;
using AStar.Dev.Utilities;
using Shouldly;

namespace AStar.Dev.Infrastructure.FilesDb.Tests.Unit.Models;

public class DirectoryNameShould
{
    [Fact]
    public void ContainTheExpectedProperties()
        => new DirectoryName { Value = "test" }
           .ToJson()
           .ShouldMatchApproved();
}
