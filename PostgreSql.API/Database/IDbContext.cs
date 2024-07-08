using Microsoft.EntityFrameworkCore;

namespace PostgreSql.API.Database;

public interface IDbContext
{
    DbSet<TEntity> Set<TEntity>() where TEntity : class;

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
