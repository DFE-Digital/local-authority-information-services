﻿using Microsoft.Extensions.DependencyInjection;

namespace OrganisationAdmin.Core.Configuration;

public static class ConfigureServices
{
    public static IServiceCollection AddCoreServices(this IServiceCollection services)
    {
        // TODO
        //var config = new MapperConfiguration(cfg =>
        //{
        //    cfg.AddProfile(new AutoMappingProfiles());
        //});

        //var mapper = config.CreateMapper();
        //services.AddSingleton(mapper);

        //services.AddAutoMapper(Assembly.GetExecutingAssembly());
        //services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        //services.AddMediatR(Assembly.GetExecutingAssembly());
        //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(UnhandledExceptionBehaviour<,>));
        //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(AuthorizationBehaviour<,>));
        //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
        //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(PerformanceBehaviour<,>));

        return services;
    }
}
