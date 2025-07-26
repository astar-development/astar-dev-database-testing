using AStar.Dev.Infrastructure.Data;
using AStar.Dev.Utilities;
using Shouldly;

namespace AStar.Dev.Infrastructure.Tests.Unit;

public class AuditableEntityShould
{
    [Fact]
    public void ContainTheExpectedProperties()
        => new MockAuditableEntity { UpdatedBy = "Test User", UpdatedOn = new (2000, 1, 1, 0, 0, 0, TimeSpan.Zero) }
           .ToJson()
           .ShouldMatchApproved();

    private class MockAuditableEntity : AuditableEntity
    {
    }
}
