using SqlServer.API.Models;

namespace SqlServer.API.Services;

public interface IUserService
{
    // Commands.
    Task Create(User user, CancellationToken cancellationToken = default);
    void Update(User user);
    void Delete(User usere);

    // Queries.
    Task<IEnumerable<User>?> GetAll(CancellationToken cancellationToken = default);
    Task<User?> GetById(int id, CancellationToken cancellationToken = default);
    Task<User?> GetByUserName(string userName, CancellationToken cancellationToken = default);
    Task<User?> GetByEmail(string userName, CancellationToken cancellationToken = default);
}
