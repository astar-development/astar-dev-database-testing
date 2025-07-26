using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AStar.Dev.Infrastructure;

/// <summary>
/// </summary>
/// <typeparam name="TEntity"></typeparam>
public interface IComplexPropertyConfiguration<TEntity> 
{
    /// <summary>
    /// </summary>
    /// <param name="builder"></param>
    /// <returns></returns>
    public ComplexPropertyBuilder<TEntity> Configure(ComplexPropertyBuilder<TEntity> builder);
}
