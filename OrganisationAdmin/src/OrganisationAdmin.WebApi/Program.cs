using Autofac.Extensions.DependencyInjection;
using MediatR;
using Microsoft.OpenApi.Models;
using OrganisationAdmin.Core.Concretions.Entities.Aggregates;
using OrganisationAdmin.Infrastructure.Persistence.Repository;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
ConfigurWebApplicationBuilderHost(builder);
ConfigurWebApplicationBuilderServices(builder);

var webApplication = builder.Build();
ConfigureWebApplication(webApplication);
webApplication.Run();

static void ConfigurWebApplicationBuilderHost(WebApplicationBuilder builder)
{
    builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
}

static void ConfigurWebApplicationBuilderServices(WebApplicationBuilder builder)
{
    // Add services to the container.
    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "OrganisationAdmin.Ui.Web.Api", Version = "v1" });
        c.EnableAnnotations();
    });

    var assemblies = new Assembly[]
          {
        typeof(Program).Assembly,
        typeof(ApplicationDbContext).Assembly,
        typeof(Organization).Assembly
          };
    builder.Services.AddMediatR(assemblies);
}

static void ConfigureWebApplication(WebApplication webApplication)
{
    // Configure the HTTP request pipeline.
    if (webApplication.Environment.IsDevelopment())
    {
        webApplication.UseSwagger();
        webApplication.UseSwaggerUI();
    }

    webApplication.UseHttpsRedirection();
    webApplication.UseAuthorization();
    webApplication.MapControllers();
}