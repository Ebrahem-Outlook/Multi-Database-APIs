using Microsoft.EntityFrameworkCore;
using PostgreSql.API.Database;

namespace PostgreSql.API;

public static class DependencyInjection
{
    public static IServiceCollection AddAPI(this IServiceCollection services, IConfiguration configuration)
    {
        string? connectionString = configuration.GetConnectionString("Local-PostgreSql");

        services.AddDbContext<ContentDbContext>(options => options.UseNpgsql(connectionString));

        services.AddScoped<IDbContext, ContentDbContext>();

        services.AddScoped<>

        return services;
    }
}
