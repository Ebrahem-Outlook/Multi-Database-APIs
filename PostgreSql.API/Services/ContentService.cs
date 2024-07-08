using Microsoft.EntityFrameworkCore;
using PostgreSql.API.Database;
using PostgreSql.API.Models;

namespace PostgreSql.API.Services;

internal sealed class ContentService(IDbContext dbContext) : IContentService
{
    public async Task Create(Content content, CancellationToken cancellationToken = default)
    {
        await dbContext.Set<Content>().AddAsync(content, cancellationToken);
        await dbContext.SaveChangesAsync(cancellationToken);
    }

    public async Task Update(Content content, CancellationToken cancellationToken)
    {
        dbContext.Set<Content>().Update(content);
        await dbContext.SaveChangesAsync(cancellationToken);
    }

    public async Task Delete(Content content, CancellationToken cancellationToken)
    {
        dbContext.Set<Content>().Remove(content);
        await dbContext.SaveChangesAsync(cancellationToken);
    }

    public async Task<IEnumerable<Content>?> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return await dbContext.Set<Content>().ToListAsync(cancellationToken);
    }

    public async Task<Content?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
    {
        return await dbContext.Set<Content>().FirstOrDefaultAsync(c => c.Id == id, cancellationToken);
    }

    public async Task<IEnumerable<Content>?> GyByAuthorIdAsync(int authorId, CancellationToken cancellationToken = default)
    {
        return await dbContext.Set<Content>().Where(c => c.AuthorId == authorId).ToListAsync(cancellationToken);
    }
}
