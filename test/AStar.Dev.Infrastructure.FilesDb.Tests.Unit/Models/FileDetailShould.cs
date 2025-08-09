using System.IO.Abstractions;
using AStar.Dev.Infrastructure.FilesDb.Models;
using JetBrains.Annotations;
using NSubstitute;
using Shouldly;

namespace AStar.Dev.Infrastructure.FilesDb.Tests.Unit.Models;

[TestSubject(typeof(FileDetail))]
public sealed class FileDetailShould
{
    [Fact]
    public void ReturnTheExpectedToStringRepresentation()
    {
        var fileDetail = new FileDetail
                         {
                             Id               = new(1),
                             DirectoryName    = new("MockDirectoryName"),
                             FileCreated      = new (new (2025,               6, 28, 22, 15, 37, DateTimeKind.Utc)),
                             FileLastModified = new (new (2025, 6, 28, 22, 15, 37, DateTimeKind.Utc)),
                             DeletionStatus      =
                                 new()
                                 {
                                     SoftDeleted       = new DateTimeOffset(new (2025, 6, 28, 22, 21, 37, DateTimeKind.Utc)),
                                     SoftDeletePending = new DateTimeOffset(new (2025, 6, 28, 22, 22, 37, DateTimeKind.Utc)),
                                     HardDeletePending = new DateTimeOffset(new (2025, 6, 28, 22, 23, 37, DateTimeKind.Utc))
                                 },
                             FileName            = new("MockFileName"),
                             FileSize            = 1234,
                             FileHandle          = new("MockFileHandle"),
                             FileLastViewed      = new DateTimeOffset(new (2025, 6, 28, 22, 20, 37, DateTimeKind.Utc)),
                             IsImage             = true,
                             ImageDetail         = new(1234, 5678),
                             UpdatedBy           = "Test User",
                             UpdatedOn           = new (new (2025, 6, 28, 22, 30, 37, DateTimeKind.Utc)),
                             FileClassifications = [new () { Id = 1, Name = "Test Classification", Celebrity = true }],
                             MoveRequired        = true
                         };

        fileDetail.ToString().ShouldMatchApproved();
    }

    [Fact]
    public void ReturnTheExpectedDataFromTheCopyConstructor()
    {
        var mockFileInfo      = Substitute.For<IFileInfo>();
        mockFileInfo.Name.Returns("MockFileName");
        mockFileInfo.DirectoryName.Returns("MockDirectoryName");
        mockFileInfo.Length.Returns(1234);

        var fileDetail = new FileDetail(mockFileInfo)
                         {
                             FileName = new("Mock File Name"), DirectoryName = new("Mock Directory Name"), UpdatedOn = new (new (2025, 6, 28, 22, 20, 37, DateTimeKind.Utc))
                         };

        fileDetail.ToString().ShouldMatchApproved();
    }
}
