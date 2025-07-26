using AStar.Dev.Infrastructure.FilesDb.Models;

namespace AStar.Dev.Infrastructure.FilesDb.Data;

/// <summary>
///
/// </summary>
public static class FileDetailLastViewedExtensions
{
    /// <summary>
    /// A lot of variations of this method have been tried, but none of them worked as expected.
    /// This one does not work as we're using SQLite for testing, and it does not support DateTimeOffset.
    /// </summary>
    /// <param name="filesContext"></param>
    /// <param name="days"></param>
    /// <param name="time"></param>
    /// <returns></returns>
    public static IQueryable<FileDetail> WhereLastViewedIsOlderThan(this IQueryable<FileDetail> filesContext, int days, TimeProvider time)
    {
        if (days == 0)
        {
            return filesContext;
        }

        var cutoff = time.GetUtcNow().AddDays(-days);
        return filesContext.Where(file => !file.FileLastViewed.HasValue || file.FileLastViewed.Value <= cutoff);
    }
}
