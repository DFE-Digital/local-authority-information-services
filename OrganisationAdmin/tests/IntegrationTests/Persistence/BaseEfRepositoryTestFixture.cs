using LocalAuthorityInformationServices.SharedKernel.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using OrganisationAdmin.Core.Concretions.Entities.Aggregates;
using OrganisationAdmin.Infrastructure.Persistence.Repository;

namespace IntegrationTests.Persistence;

public abstract class BaseEfRepositoryTestFixture
{
    protected ApplicationDbContext _dbContext;

    protected BaseEfRepositoryTestFixture()
    {
        var options = CreateNewContextOptions();
        var mockEventDispatcher = new Mock<IDomainEventDispatcher>();

        _dbContext = new ApplicationDbContext(options, mockEventDispatcher.Object);
    }

    protected static DbContextOptions<ApplicationDbContext> CreateNewContextOptions()
    {
        // Create a fresh service provider, and therefore a fresh
        // InMemory database instance.
        var serviceProvider = new ServiceCollection()
            .AddEntityFrameworkInMemoryDatabase()
            .BuildServiceProvider();

        // Create a new options instance telling the context to use an
        // InMemory database and the new service provider.
        var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
        builder.UseInMemoryDatabase("organizations")
               .UseInternalServiceProvider(serviceProvider);

        return builder.Options;
    }

    protected EfRepository<Organization> GetRepository()
    {
        return new EfRepository<Organization>(_dbContext);
    }
}
