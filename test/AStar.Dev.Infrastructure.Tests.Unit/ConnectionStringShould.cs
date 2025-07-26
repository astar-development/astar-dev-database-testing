using AStar.Dev.Infrastructure.Data;
using AStar.Dev.Utilities;
using Shouldly;

namespace AStar.Dev.Infrastructure.Tests.Unit;

public class ConnectionStringShould
{
    [Fact]
    public void ContainTheExpectedProperties()
        => new ConnectionString { Value = "Clearly, this is not a valid connection string" }
           .ToJson()
           .ShouldMatchApproved();
}
