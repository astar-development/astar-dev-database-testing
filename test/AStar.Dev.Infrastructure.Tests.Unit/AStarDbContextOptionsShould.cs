using AStar.Dev.Infrastructure.Data;
using AStar.Dev.Utilities;
using Shouldly;

namespace AStar.Dev.Infrastructure.Tests.Unit;

public class AStarDbContextOptionsShould
{
    [Fact]
    public void ContainTheExpectedProperties()
        => new AStarDbContextOptions { EnableLogging = true, IncludeSensitiveData = true }
           .ToJson()
           .ShouldMatchApproved();
}
