using Microsoft.EntityFrameworkCore;
using PostgreSql.API.Database;
using PostgreSql.API.Services;

namespace PostgreSql.API;

public static class DependencyInjection
{
    public static IServiceCollection AddAPI(this IServiceCollection services, IConfiguration configuration)
    {
        string? connectionString = configuration.GetConnectionString("Docker-PostgreSql");

        services.AddDbContext<AppDbContext>(options => options.UseNpgsql(connectionString));

        services.AddScoped<IDbContext, AppDbContext>();

        services.AddScoped<IContentService, ContentService>();

        return services;
    }
}
