using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace OrganisationAdmin.Infrastructure;

public static class ConfigureServices
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {

        //services.AddScoped<AuditableEntitySaveChangesInterceptor>();

        //if (configuration.GetValue<bool>("UseInMemoryDatabase"))
        //{
        //    services.AddDbContext<LAHubDbContext>(options =>
        //        options.UseInMemoryDatabase("LAHubDb"));
        //}
        //else if (configuration.GetValue<bool>("UseSqlServerDatabase"))
        //{
        //    services.AddDbContext<LAHubDbContext>(options =>
        //        options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
        //            builder => builder.MigrationsAssembly(typeof(LAHubDbContext).Assembly.FullName)));
        //}
        //else
        //{
        //    services.AddDbContext<LAHubDbContext>(options =>
        //        options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"),
        //            builder => builder.MigrationsAssembly(typeof(LAHubDbContext).Assembly.FullName)));
        //}

        //services.AddScoped<ILAHubDbContext>(provider => provider.GetRequiredService<LAHubDbContext>());

        //services.AddScoped<ApplicationDbContextInitialiser>();

        //services
        //    .AddDefaultIdentity<ApplicationUser>()
        //    .AddRoles<IdentityRole>()
        //    .AddEntityFrameworkStores<LAHubDbContext>();

        //services.AddIdentityServer()
        //    .AddApiAuthorization<ApplicationUser, LAHubDbContext>();

        //services.AddTransient<IDateTime, DateTimeService>();
        //services.AddTransient<IIdentityService, IdentityService>();

        //services.AddAuthentication()
        //    .AddIdentityServerJwt();

        //services.AddAuthorization(options =>
        //    options.AddPolicy("CanPurge", policy => policy.RequireRole("Administrator")));

        return services;
    }
}
