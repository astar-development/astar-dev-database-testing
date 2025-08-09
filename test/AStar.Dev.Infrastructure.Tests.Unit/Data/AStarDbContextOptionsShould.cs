using AStar.Dev.Infrastructure.Data;
using AStar.Dev.Utilities;

namespace AStar.Dev.Infrastructure.Tests.Unit.Data;

[TestSubject(typeof(AStarDbContextOptions))]
public class AStarDbContextOptionsShould
{
    [Fact]
    public void ContainTheExpectedProperties()
        => new AStarDbContextOptions { EnableLogging = true, IncludeSensitiveData = true }
           .ToJson()
           .ShouldMatchApproved();
}
