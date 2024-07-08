using Microsoft.EntityFrameworkCore;
using SqlServer.API.Models;

namespace SqlServer.API.Database;

public sealed class UserDbContext : DbContext, IDbContext
{
    public UserDbContext(DbContextOptions<UserDbContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }

    public new DbSet<TEntity> Set<TEntity>() where TEntity : class
    {
        return base.Set<TEntity>(); 
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Local-SqlServer");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasKey(u => u.Id);

        modelBuilder.Entity<User>().Property(u => u.UserName)
            .IsRequired()
            .HasMaxLength(20);

        modelBuilder.Entity<User>().Property(u => u.Email)
            .IsRequired()
            .HasMaxLength(20);

        modelBuilder.Entity<User>().Property(u => u.PasswordHash)
            .IsRequired()
            .HasMaxLength(20);
    }
}
