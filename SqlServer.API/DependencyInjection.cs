using Microsoft.EntityFrameworkCore;
using SqlServer.API.Database;
using SqlServer.API.Services;

namespace SqlServer.API;

public static class DependencyInjection
{
    public static IServiceCollection AddAPI(this IServiceCollection services, IConfiguration configuration)
    {
        string? connectionString = configuration.GetConnectionString("Local-SqlServer");

        services.AddDbContext<UserDbContext>(options => options.UseSqlServer(connectionString));

        services.AddScoped<IDbContext, UserDbContext>();

        services.AddScoped<IUserService, UserService>();

        return services;
    }
}
