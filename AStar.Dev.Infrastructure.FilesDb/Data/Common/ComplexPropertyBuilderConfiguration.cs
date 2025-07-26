using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AStar.Dev.Infrastructure.FilesDb.Data.Common;

/// <summary>
/// 
/// </summary>
internal static class ComplexPropertyBuilderConfiguration
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <param name="propertyBuilder"></param>
    /// <param name="configuration"></param>
    /// <returns></returns>
    public static ComplexPropertyBuilder<TEntity> Configure<TEntity>(this ComplexPropertyBuilder<TEntity> propertyBuilder, IComplexPropertyConfiguration<TEntity> configuration)
        where TEntity : class
    {
        configuration.Configure(propertyBuilder);
        return propertyBuilder;
    }
}
