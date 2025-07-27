using AStar.Dev.Infrastructure.FilesDb.Models;
using AStar.Dev.Utilities;

namespace AStar.Dev.Infrastructure.FilesDb.Data;

/// <summary>
/// </summary>
public static class FileDetailDirectoryNameExtensions
{
    /// <summary>
    /// </summary>
    /// <param name="filesContext"></param>
    /// <param name="directoryName"></param>
    /// <param name="includeSubDirectories"></param>
    /// <returns></returns>
    public static IQueryable<FileDetail> WhereDirectoryNameMatches(this IQueryable<FileDetail> filesContext, string directoryName, bool includeSubDirectories) =>
        includeSubDirectories
            ? filesContext.Where(file => file.DirectoryName.Value.StartsWith(directoryName.RemoveTrailing(@"\")))
            : filesContext.Where(file => file.DirectoryName.Value == directoryName.RemoveTrailing(@"\"));
}
