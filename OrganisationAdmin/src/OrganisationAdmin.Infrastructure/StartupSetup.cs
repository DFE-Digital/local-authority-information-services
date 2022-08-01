using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OrganisationAdmin.Infrastructure.Persistence.Repository;

namespace OrganisationAdmin.Infrastructure;

public static class StartupSetup
{
    public static void AddApplicationDbContext(this IServiceCollection services, string connectionString) =>
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlite(connectionString)); // will be created in web project root
}
