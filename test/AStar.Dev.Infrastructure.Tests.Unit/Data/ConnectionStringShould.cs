using AStar.Dev.Infrastructure.Data;
using AStar.Dev.Utilities;

namespace AStar.Dev.Infrastructure.Tests.Unit.Data;

[TestSubject(typeof(ConnectionString))]
public class ConnectionStringShould
{
    [Fact]
    public void ContainTheExpectedProperties()
        => new ConnectionString { Value = "some mock connection string" }
           .ToJson()
           .ShouldMatchApproved();

    [Fact]
    public void ImplicitlyMapToTheExpectedString()
    {
        string sut = new ConnectionString { Value = "some mock connection string" };

        sut.ShouldBe("some mock connection string");
    }

    [Fact]
    public void ImplicitlyMapToTheExpectedInstance()
    {
        ConnectionString sut = "some mock connection string";

        sut.ToJson().ShouldMatchApproved();
    }
}
