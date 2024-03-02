using Innovaxis.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Innovaxis.Infrastructure.Context;

public sealed class InnovaxisDbContext : DbContext
{
    public InnovaxisDbContext(DbContextOptions<InnovaxisDbContext> options) : base(options)
    {
    }

    #region DbSets

    public DbSet<TaskEntity> Tasks { get; set; }

    public DbSet<CategoryEntity> Categories { get; set; }

    public DbSet<UserEntity> Users { get; set; }

    #endregion


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TaskEntity>()
            .Property(t => t.DueDate)
            .HasDefaultValueSql("GetDate()")
            .IsRequired();

        modelBuilder.Entity<TaskEntity>()
            .HasMany(e => e.Users)
            .WithMany(u => u.Tasks);

        modelBuilder.Entity<CategoryEntity>()
            .HasMany(e => e.Tasks)
            .WithOne(t => t.Category);
    }
}