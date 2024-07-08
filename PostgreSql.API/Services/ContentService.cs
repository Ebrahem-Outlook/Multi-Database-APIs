using PostgreSql.API.Database;
using PostgreSql.API.Models;

namespace PostgreSql.API.Services;

internal sealed class ContentService(IDbContext dbContext) : IContentService
{
    public Task Create(Content content, CancellationToken cancellationToken = default)
    {
        dbContext.Set<Content>().AddAsync(content, cancellationToken);
    }

    public void Update(Content content)
    {
        dbContext.Set<Content>().Update(content);
    }

    public async Task Delete(Content content, CancellationToken cancellationToken)
    {
        dbContext.Set<Content>().Remove(content);
        await dbContext.SaveChangesAsync(cancellationToken);
    }

    public Task<IEnumerable<Content>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Content> GetByIdAsync(Content content, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Content>> GyByAuthorIdAsync(Content content, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    
}
