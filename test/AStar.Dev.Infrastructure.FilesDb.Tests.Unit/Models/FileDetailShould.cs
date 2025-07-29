using AStar.Dev.Infrastructure.FilesDb.Models;
using AStar.Dev.Utilities;
using Shouldly;

namespace AStar.Dev.Infrastructure.FilesDb.Tests.Unit.Models;

public class FileDetailShould
{
    [Fact]
    public void ContainTheExpectedProperties()
        => new FileDetail
           {
               Id            = new (68),
               DirectoryName = new ("mock-directory-name"),
               FileName      = new ("mock-file-name"),
               ImageDetail   = new (7, 8),
               FileHandle    = new ("mock-file-handle"),
               DeletionStatus =
                   new()
                   {
                       HardDeletePending = new DateTimeOffset(2025, 07, 28, 1, 2, 3, TimeSpan.Zero),
                       SoftDeletePending = new DateTimeOffset(2025, 07, 28, 2, 3, 4, TimeSpan.Zero),
                       SoftDeleted       = new DateTimeOffset(2025, 07, 28, 3, 4, 5, TimeSpan.Zero)
                   },
               FileClassifications = new List<FileClassification>
                                     {
                                         new ()
                                         {
                                             Celebrity = true,
                                             Id        = 1,
                                             Name      = "Celebrity",
                                             FileDetails   = new List<FileDetail>
                                                             {
                                                                 new ()
                                                                 {
                                                                     DirectoryName = new ("mock-directory-name2") ,
                                                                     FileName      = new("mock-file-name"),
                                                                     UpdatedOn     = new (2025, 07, 28, 1, 2, 3, TimeSpan.Zero)
                                                                 }
                                                             },
                                             FileNameParts = new List<FileNamePart> { new () { Text        = "mock-file-name-part" } }
                                         }
                                     },
               FileSize         = 1245,
               IsImage          = true,
               FileCreated      = new (2025, 07, 28, 5,  6,  7,  TimeSpan.Zero),
               FileLastModified = new (2025, 07, 28, 10, 20, 30, TimeSpan.Zero),
               FileLastViewed   = new DateTimeOffset(2025, 07, 28, 11, 22, 33, TimeSpan.Zero),
               UpdatedBy        = "mock-user-name",
               UpdatedOn        = new (2025, 07, 28, 8, 7, 9, TimeSpan.Zero),
               MoveRequired     = true
           }
           .ToJson()
           .ShouldMatchApproved();
}
