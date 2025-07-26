using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DatabaseTesting.Configurations;

internal static class ComplexPropertyBuilderConfiguration
{
    public static ComplexPropertyBuilder<TEntity> Configure<TEntity>(
        this ComplexPropertyBuilder<TEntity> propertyBuilder,
        IComplexPropertyConfiguration<TEntity> configuration)
        where TEntity : class
    {
        configuration.Configure(propertyBuilder);
        return propertyBuilder;
    }
}