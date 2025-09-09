using AStar.Dev.Infrastructure.FilesDb.Models;
using AStar.Dev.Utilities;

namespace AStar.Dev.Infrastructure.FilesDb.Tests.Unit.Models;

public class FileNameShould
{
    [Fact]
    public void ContainTheExpectedProperties()
        => new FileName("mock-file-name")
           .ToJson()
           .ShouldMatchApproved();
}
