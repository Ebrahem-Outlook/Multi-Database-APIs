using Microsoft.EntityFrameworkCore;
using SqlLite.API.Database;
using SqlLite.API.Services;

namespace SqlLite.API;

public static class DependencyInjection
{
    public static IServiceCollection AddAPI(this IServiceCollection services, IConfiguration configuration)
    {
        string? connectionString = configuration.GetConnectionString("Docker-SqlLite");

        services.AddDbContext<AppDbContext>(options => options.UseSqlite(connectionString));

        services.AddScoped<IDbContext, AppDbContext>();

        services.AddScoped<INotificationService, NotificationService>();

        return services;
    }
}
