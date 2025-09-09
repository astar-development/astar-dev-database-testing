using AStar.Dev.Infrastructure.FilesDb.Models;
using AStar.Dev.Utilities;

namespace AStar.Dev.Infrastructure.FilesDb.Tests.Unit.Models;

[TestSubject(typeof(ImageDetail))]
public class ImageDetailsShould
{
    [Fact]
    public void ContainTheExpectedProperties()
        => new ImageDetail(1234, 5678).ToJson().ShouldMatchApproved();

    [Fact]
    public void ReturnTheExpectedToString()
        => new ImageDetail(1234, 5678).ToString().ShouldMatchApproved();
}
