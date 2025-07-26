using AStar.Dev.Infrastructure.FilesDb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AStar.Dev.Infrastructure.FilesDb.Data.Configurations;

internal sealed class DirectoryNameConfiguration : IComplexPropertyConfiguration<DirectoryName>
{
    public ComplexPropertyBuilder<DirectoryName> Configure(ComplexPropertyBuilder<DirectoryName> builder)
    {
        builder.Property(directoryName => directoryName.Value)
            .HasColumnName("DirectoryName")
            .HasColumnType("nvarchar(256)");

        return builder;
    }
}
