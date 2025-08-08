using AStar.Dev.Utilities;
using Shouldly;

namespace AStar.Dev.Infrastructure.FilesDb.Models;

public class FileSizeShould
{
    [Fact]
    public void ContainTheExpectedProperties()
        => FileSize.Create(1, 2, 3)
                   .ToJson()
                   .ShouldMatchApproved();
}
