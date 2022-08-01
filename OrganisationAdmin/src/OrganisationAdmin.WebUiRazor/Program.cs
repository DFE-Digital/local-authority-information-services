using Ardalis.ListStartupServices;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using OrganisationAdmin.Core;
using OrganisationAdmin.Core.Configuration;
using OrganisationAdmin.Infrastructure;
using OrganisationAdmin.Infrastructure.Persistence.Repository;
using OrganisationAdmin.WebUiRazor;
using Serilog;

var builder = WebApplication.CreateBuilder(args);
ConfigurWebApplicationBuilderHost(builder);
ConfigureWebApplicationBuilderServices(builder);

var webApplication = builder.Build();
ConfigureWebApplication(webApplication);
webApplication.Run();

static void ConfigurWebApplicationBuilderHost(WebApplicationBuilder builder)
{
    builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
    builder.Host.UseSerilog((_, config) => config.ReadFrom.Configuration(builder.Configuration));
    builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder =>
    {
        containerBuilder.RegisterModule(new DefaultCoreModule());
        containerBuilder.RegisterModule(new DefaultInfrastructureModule(builder.Environment.EnvironmentName == "Development"));
    });
}

static void ConfigureWebApplicationBuilderServices(WebApplicationBuilder builder)
{
    builder.Services.Configure<CookiePolicyOptions>(options =>
    {
        options.CheckConsentNeeded = context => true;
        options.MinimumSameSitePolicy = SameSiteMode.None;
    });
    string connectionString = builder.Configuration.GetConnectionString("SqliteConnection");  //Configuration.GetConnectionString("DefaultConnection");
    builder.Services.AddApplicationDbContext(connectionString);
    builder.Services.AddControllersWithViews();
    builder.Services.AddRazorPages();
    builder.Services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
        c.EnableAnnotations();
    });
    // add list services for diagnostic purposes - see https://github.com/ardalis/AspNetCoreStartupServices
    builder.Services.Configure<ServiceConfig>(config =>
    {
        config.Services = new List<ServiceDescriptor>(builder.Services);

        // optional - default path to view services is /listallservices - recommended to choose your own path
        config.Path = "/listservices";
    });
    //builder.Logging.AddAzureWebAppDiagnostics(); add this if deploying to Azure
}

static void ConfigureWebApplication(WebApplication webApplication)
{
    if (webApplication.Environment.IsDevelopment())
    {
        webApplication.UseDeveloperExceptionPage();
        webApplication.UseShowAllServicesMiddleware();
    }
    else
    {
        webApplication.UseExceptionHandler("/Home/Error");
        webApplication.UseHsts();
    }

    webApplication.UseRouting();
    webApplication.UseHttpsRedirection();
    webApplication.UseStaticFiles();
    webApplication.UseCookiePolicy();
    webApplication.UseSwagger();                                                                       // Enable middleware to serve generated Swagger as a JSON endpoint.
    webApplication.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1"));      // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), specifying the Swagger JSON endpoint.
    webApplication.UseEndpoints(endpoints =>
    {
        endpoints.MapDefaultControllerRoute();
        endpoints.MapRazorPages();
    });
    
    using (var scope = webApplication.Services.CreateScope())                                          // Seed Database
    {
        var services = scope.ServiceProvider;

        try
        {
            var context = services.GetRequiredService<ApplicationDbContext>();
            // context.Database.Migrate();
            context.Database.EnsureCreated();
            SeedData.Initialize(services);
        }
        catch (Exception ex)
        {
            var logger = services.GetRequiredService<ILogger<Program>>();
            logger.LogError(ex, "An error occurred seeding the DB. {exceptionMessage}", ex.Message);
        }
    }
    webApplication.UseHttpsRedirection();
    webApplication.UseStaticFiles();
    webApplication.UseRouting();
    webApplication.UseAuthorization();
    webApplication.MapRazorPages();
}