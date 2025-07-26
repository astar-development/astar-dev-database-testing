using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AStar.Dev.Infrastructure.FilesDb.Data.Common;

/// <summary>
/// 
/// </summary>
/// <typeparam name="TEntity"></typeparam>
internal interface IComplexPropertyConfiguration<TEntity> where TEntity : class
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="builder"></param>
    /// <returns></returns>
    ComplexPropertyBuilder<TEntity> Configure(ComplexPropertyBuilder<TEntity> builder);
}
