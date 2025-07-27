using AStar.Dev.Infrastructure.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AStar.Dev.Infrastructure.Tests.Unit;

public class ComplexPropertyBuilderConfigurationShould
{
    private sealed class DummyEntity
    {
        public Address Address { get; set; } = new();
    }

    private sealed class Address
    {
        public string Street { get; set; } = string.Empty;
    }

    private sealed class TestConfiguration : IComplexPropertyConfiguration<Address>
    {
        public bool WasCalled { get; private set; }

        public void Configure(ComplexPropertyBuilder<Address> builder) => WasCalled = true;
    }

    [Fact]
    public void Configure_ShouldInvokeConfigurationAndReturnSameBuilder()
    {
        var modelBuilder   = new ModelBuilder();
        var entityBuilder  = modelBuilder.Entity<DummyEntity>();
        var complexBuilder = entityBuilder.ComplexProperty(e => e.Address);

        var config = new TestConfiguration();

        var result = complexBuilder.Configure(config);

        Assert.True(config.WasCalled);
        Assert.Same(complexBuilder, result);
    }
}
