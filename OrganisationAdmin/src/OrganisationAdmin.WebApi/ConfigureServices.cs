using MediatR;
using OrganisationAdmin.Infrastructure.Data;
using System.Reflection;

namespace OrganisationAdmin.WebApi;

public static class ConfigureServices
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        //services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        services.AddMediatR(Assembly.GetExecutingAssembly());
        

        return services;
    }
}
