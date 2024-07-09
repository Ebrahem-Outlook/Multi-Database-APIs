using Microsoft.EntityFrameworkCore;
using SqlLite.API.Database;
using SqlLite.API.Models;

namespace SqlLite.API.Services;

internal sealed class NotificationService(IDbContext dbContext) : INotificationService
{
    public async Task CreateAsync(Notification notification, CancellationToken cancellationToken)
    {
        await dbContext.Set<Notification>().AddAsync(notification, cancellationToken);
        await dbContext.SaveChangesAsync(cancellationToken);
    }

    public async Task<IEnumerable<Notification>?> GetAllAsync(CancellationToken cancellationToken)
    {
        return await dbContext.Set<Notification>().ToListAsync(cancellationToken);
    }

    public async Task<Notification?> GetByIdAsync(int id, CancellationToken cancellationToken)
    {
        return await dbContext.Set<Notification>().FirstOrDefaultAsync(n => n.Id == id, cancellationToken);
    }

    public async Task<IEnumerable<Notification>?> GetByUserIdAsync(int userId, CancellationToken cancellationToken)
    {
        return await dbContext.Set<Notification>().Where(n => n.UserId == userId).ToListAsync(cancellationToken);
    }
}
