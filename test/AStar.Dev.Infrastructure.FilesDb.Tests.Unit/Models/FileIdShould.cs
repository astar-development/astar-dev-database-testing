using AStar.Dev.Infrastructure.FilesDb.Models;
using AStar.Dev.Utilities;
using Shouldly;

namespace AStar.Dev.Infrastructure.FilesDb.Tests.Unit.Models;

public class FileIdShould
{
    [Fact]
    public void ContainTheExpectedProperties()
        => new FileId { Value = 68 }
           .ToJson()
           .ShouldMatchApproved();
}
