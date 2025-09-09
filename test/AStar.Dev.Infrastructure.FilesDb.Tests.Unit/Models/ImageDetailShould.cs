using AStar.Dev.Infrastructure.FilesDb.Models;
using AStar.Dev.Utilities;

namespace AStar.Dev.Infrastructure.FilesDb.Tests.Unit.Models;

public class ImageDetailShould
{
    [Fact]
    public void ContainTheExpectedProperties()
        => new ImageDetail(123, 456)
           .ToJson()
           .ShouldMatchApproved();
}
