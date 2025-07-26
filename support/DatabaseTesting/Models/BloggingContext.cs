using DatabaseTesting.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DatabaseTesting.Models;

public class BloggingContext : DbContext
{
    public DbSet<Blog>       Blogs { get; set; } = null!;
    public DbSet<Post>       Posts { get; set; } = null!;
    public DbSet<FileDetail> Files { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=filesDb;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(BloggingContext).Assembly);

        new FileDetailConfiguration().Configure(modelBuilder.Entity<FileDetail>());
    }
}

internal interface IComplexPropertyConfiguration<TEntity> where TEntity : class
{
    public ComplexPropertyBuilder<TEntity> Configure(ComplexPropertyBuilder<TEntity> builder);
}
