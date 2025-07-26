using AStar.Dev.Infrastructure.FilesDb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AStar.Dev.Infrastructure.FilesDb.Data.Configurations;

internal sealed class ImageDetailConfiguration : IComplexPropertyConfiguration<ImageDetail>
{
    public ComplexPropertyBuilder<ImageDetail> Configure(ComplexPropertyBuilder<ImageDetail> builder)
    {
        builder.Property(image => image.Width).HasColumnName("ImageWidth");
        builder.Property(image => image.Height).HasColumnName("ImageHeight");

        return builder;
    }
}
