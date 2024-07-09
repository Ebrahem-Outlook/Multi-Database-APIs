using SqlLite.API.Models;

namespace SqlLite.API.Services;

public interface INotificationService
{
    // Commands.
    Task CreateAsync(Notification notification, CancellationToken cancellationToken);

    // Queries.
    Task<IEnumerable<Notification>?> GetAllAsync(CancellationToken cancellationToken);
    Task<Notification?> GetByIdAsync(int id, CancellationToken cancellationToken);
    Task<IEnumerable<Notification>?> GetByUserIdAsync(int userId, CancellationToken cancellationToken);
}
