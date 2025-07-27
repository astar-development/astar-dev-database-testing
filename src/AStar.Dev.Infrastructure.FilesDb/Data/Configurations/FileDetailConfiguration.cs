using AStar.Dev.Infrastructure.Data.Configurations;
using AStar.Dev.Infrastructure.FilesDb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AStar.Dev.Infrastructure.FilesDb.Data.Configurations;

/// <summary>
/// </summary>
public class FileDetailConfiguration : IEntityTypeConfiguration<FileDetail>
{
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<FileDetail> builder)
    {
        builder.ToTable("FileDetail");

        builder.HasKey(file => file.Id);

        builder.Property(file => file.Id)
               .HasConversion(fileId => fileId.Value, fileId => new (fileId));

        builder.Property(file => file.FileName)
               .HasColumnType("nvarchar(256)")
               .HasConversion(fileName => fileName.Value, fileName => new (fileName));

        builder.Ignore(fileDetail => fileDetail.DirectoryName);
        builder.Ignore(fileDetail => fileDetail.FullNameWithPath);

        builder.Property(file => file.FileHandle)
               .HasColumnType("nvarchar(256)")
               .HasConversion(fileHandle => fileHandle.Value, fileHandle => new (fileHandle));

        builder.ComplexProperty(fileDetail => fileDetail.ImageDetail)
            .Configure(new ImageDetailConfiguration());
        builder.ComplexProperty(fileDetail => fileDetail.DirectoryName)
            .Configure(new DirectoryNameConfiguration());

        builder.ComplexProperty(fileDetail => fileDetail.DeletionStatus)
               .Configure(new DeletionStatusConfiguration());

        // Will want the handle to be unique, but not yet
        builder.HasIndex(fileDetail => fileDetail.FileHandle);
        builder.HasIndex(fileDetail => fileDetail.FileName);
        builder.HasIndex(fileDetail => fileDetail.FileSize);
    }
}
