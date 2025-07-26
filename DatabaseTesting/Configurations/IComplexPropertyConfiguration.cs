using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DatabaseTesting.Configurations;

internal interface IComplexPropertyConfiguration<TEntity> where TEntity : class
{
    ComplexPropertyBuilder<TEntity> Configure(ComplexPropertyBuilder<TEntity> builder);
}