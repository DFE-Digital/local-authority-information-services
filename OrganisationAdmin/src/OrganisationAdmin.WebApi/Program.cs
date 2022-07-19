using OrganisationAdmin.Infrastructure;
using OrganisationAdmin.WebApi;
using Autofac;
using OrganisationAdmin.Infrastructure.Data;
using Autofac.Extensions.DependencyInjection;
using PluralsightDdd.SharedKernel.Interfaces;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer()
                .AddInfrastructureServices(builder.Configuration)
                .AddApplicationServices();

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

builder.Host.ConfigureContainer<ContainerBuilder>(builder => builder.RegisterGeneric(typeof(EfRepository<>))
        .As(typeof(IRepository<>))
        .InstancePerLifetimeScope());

//builder.Host.ConfigureContainer<ContainerBuilder>(builder => builder
//          .RegisterType<Mediator>()
//          .As<IMediator>()
//          .InstancePerLifetimeScope());




builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
