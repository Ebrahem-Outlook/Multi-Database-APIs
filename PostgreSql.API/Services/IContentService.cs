using PostgreSql.API.Models;

namespace PostgreSql.API.Services;

public interface IContentService
{
    // Commands
    Task Create(Content content, CancellationToken cancellationToken = default);
    Task Update(Content content, CancellationToken cancellationToken = default);
    Task Delete(Content content, CancellationToken cancellationToken = default);

    // Queries.
    Task<IEnumerable<Content>?> GetAllAsync(CancellationToken cancellationToken = default);
    Task<Content?> GetByIdAsync(int id, CancellationToken cancellationToken = default);
    Task<IEnumerable<Content>?> GyByAuthorIdAsync(int authroId, CancellationToken cancellationToken = default);
}
