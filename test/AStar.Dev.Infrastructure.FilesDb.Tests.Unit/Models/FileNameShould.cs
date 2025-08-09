using AStar.Dev.Utilities;
using Shouldly;

namespace AStar.Dev.Infrastructure.FilesDb.Models;

public class FileNameShould
{
    [Fact]
    public void ContainTheExpectedProperties()
        => new FileName ("mock-file-name")
           .ToJson()
           .ShouldMatchApproved();
}
