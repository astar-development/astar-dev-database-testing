﻿using AStar.Dev.Infrastructure.FilesDb.Models;
using AStar.Dev.Technical.Debt.Reporting;
using AStar.Dev.Utilities;

namespace AStar.Dev.Infrastructure.FilesDb;

/// <summary>
/// </summary>
[Refactor(1, 1, "I think these methods have been implemented in the files api project - remove duplicate methods / files.")]
public static class EnumerableExtensions
{
    /// <summary>
    /// </summary>
    /// <param name="files">
    /// </param>
    /// <param name="searchType">
    /// </param>
    /// <param name="cancellationToken">
    /// </param>
    /// <returns>
    /// </returns>
    public static IEnumerable<FileDetail> FilterImagesIfApplicable(this IEnumerable<FileDetail> files, string                       searchType, CancellationToken            cancellationToken) =>
        cancellationToken.IsCancellationRequested
            ? files
            : FilterImagesIfApplicable(files, searchType);

    /// <summary>
    /// </summary>
    /// <param name="files">
    /// </param>
    /// <param name="sortOrder">
    /// </param>
    /// <returns>
    /// </returns>
    public static IEnumerable<FileDetail> OrderFiles(this IEnumerable<FileDetail> files, SortOrder sortOrder) =>
        sortOrder switch
        {
            SortOrder.NameAscending  => files.OrderBy(f => f.FileName),
            SortOrder.NameDescending => files.OrderByDescending(f => f.FileName),
            SortOrder.SizeAscending  => files.OrderBy(f => f.FileSize),
            SortOrder.SizeDescending => files.OrderByDescending(f => f.FileSize),
            _                        => files
        };

    /// <summary>
    ///     Gets the count of duplicates, grouped by Size, Height and Width.
    /// </summary>
    /// <param name="files">
    ///     The files to return grouped together.
    /// </param>
    /// <param name="cancellationToken">
    /// </param>
    /// <returns>
    /// </returns>
    public static int GetDuplicatesCount(this IEnumerable<FileDetail> files, CancellationToken cancellationToken)
    {
        if (cancellationToken.IsCancellationRequested)
        {
            return 0;
        }

        // var duplicatesBySize = files
        //                        .Join(f=>f.ImageDetails).AsEnumerable()
        //                             .GroupBy(file => FileSize.Create(file.FileSize, file.Height, file.Width),
        //                                      new FileSizeEqualityComparer()).Where(fileGroups => fileGroups.Count() > 1)
        //                             .ToArray();
        //
        // return duplicatesBySize.Length;
        return 0;
    }

    /// <summary>
    ///     Gets the count of duplicates, grouped by Size, Height and Width.
    /// </summary>
    /// <param name="files">
    ///     The files to return grouped together.
    /// </param>
    /// <returns>
    /// </returns>
    public static IEnumerable<IGrouping<FileSize, FileDetail>> GetDuplicates(this IEnumerable<FileDetail> files) =>

        // return files
        //        .GroupBy(file => FileSize.Create(file.FileSize, file.Height, file.Width),
        //                 new FileSizeEqualityComparer()).Where(fileGroups => fileGroups.Count() > 1);
        [];

    private static IEnumerable<FileDetail> FilterImagesIfApplicable(IEnumerable<FileDetail> files, string searchType) =>
        searchType != "Images"
            ? files
            : files.Where(file => file.FileName.Value.IsImage());
}
