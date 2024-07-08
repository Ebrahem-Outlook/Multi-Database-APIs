using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace PostgreSql.API.Database;

public sealed class ContentDbContext : DbContext, IDbContext
{
    public ContentDbContext(DbContextOptions<ContentDbContext> options) : base(options) { }

    public new async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
    {
        return await base.SaveChangesAsync(cancellationToken);
    }

    public new DbSet<TEntity> Set<TEntity>() where TEntity : class
    {
        return base.Set<TEntity>();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
