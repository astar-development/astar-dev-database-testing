using DatabaseTesting.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DatabaseTesting.Configurations;

public class FileDetailConfiguration : IEntityTypeConfiguration<FileDetail>
{
    public void Configure(EntityTypeBuilder<FileDetail> entity)
    {
        entity.ToTable("FileDetail");

        entity.HasKey(file => file.Id);

        entity.Property(file => file.Id)
              .HasColumnName("FileId")
              .HasColumnType("uniqueidentifier")
              .IsRequired();

        entity.Property(file => file.FileName).HasColumnType("nvarchar(256)");

        entity.Property(file => file.DirectoryPath).HasColumnType("nvarchar(256)");

        entity.Property(file => file.FileType).HasColumnType("nvarchar(3)");

        entity.ComplexProperty(fileDetail => fileDetail.ImageDetail).Configure(new ImageDetailConfiguration());
    }
}
