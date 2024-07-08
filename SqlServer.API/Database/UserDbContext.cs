using Microsoft.EntityFrameworkCore;
using SqlServer.API.Models;
using System.Reflection;

namespace SqlServer.API.Database;

public sealed class UserDbContext : DbContext, IDbContext
{
    public UserDbContext(DbContextOptions<UserDbContext> options) : base(options) { }

    public new DbSet<TEntity> Set<TEntity>() where TEntity : class
    {
        return base.Set<TEntity>(); 
    }

    public new  async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
    {
        return await base.SaveChangesAsync(cancellationToken);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
