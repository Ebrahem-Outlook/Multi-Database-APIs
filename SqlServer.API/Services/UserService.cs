using Microsoft.EntityFrameworkCore;
using SqlServer.API.Database;
using SqlServer.API.Models;

namespace SqlServer.API.Services;

internal sealed class UserService(IDbContext dbContext) : IUserService
{
    public async Task Create(User user, CancellationToken cancellationToken)
    {
        await dbContext.Set<User>().AddAsync(user);
    }

    public void Update(User user)
    {
        dbContext.Set<User>().Update(user);
    }

    public void Delete(User user)
    {
        dbContext.Set<User>().Remove(user);
    }

    public async Task<IEnumerable<User>?> GetAll(CancellationToken cancellationToken)
    {
        return await dbContext.Set<User>().ToListAsync(cancellationToken);
    }

    public async Task<User?> GetByEmail(string email, CancellationToken cancellationToken)
    {
        return await dbContext.Set<User>().FirstOrDefaultAsync(u => u.Email == email, cancellationToken);
    }

    public async Task<User?> GetById(int id, CancellationToken cancellationToken)
    {
        return await dbContext.Set<User>().FirstOrDefaultAsync(u => u.Id == id, cancellationToken);
    }

    public async Task<User?> GetByUserName(string userName, CancellationToken cancellationToken)
    {
        return await dbContext.Set<User>().FirstOrDefaultAsync(u => u.UserName == userName, cancellationToken);
    }
}
