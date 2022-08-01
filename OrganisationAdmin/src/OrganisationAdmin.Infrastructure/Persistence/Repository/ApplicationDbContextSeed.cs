using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OrganisationAdmin.Core.Concretions.Entities.Aggregates;

namespace OrganisationAdmin.Infrastructure.Persistence.Repository
{
    public class ApplicationDbContextSeed
    {
        private DateTimeOffset _testDate = DateTime.UtcNow.Date;
        private readonly ApplicationDbContext _context;
        private readonly ILogger<ApplicationDbContextSeed> _logger;

        private readonly Organization Organisation1 = new Organization("Org1", "Description1", string.Empty, string.Empty, string.Empty);
        private readonly Organization Organisation2 = new Organization("Org2", "Description2", string.Empty, string.Empty, string.Empty);
        private readonly Organization Organisation3 = new Organization("Org3", "Description3", string.Empty, string.Empty, string.Empty);
        private readonly Organization Organisation4 = new Organization("Org4", "Description4", string.Empty, string.Empty, string.Empty);

        public ApplicationDbContextSeed
        (
            ApplicationDbContext context,
            ILogger<ApplicationDbContextSeed> logger
        )
        {
            _context = context;
            _logger = logger;
        }

        public async Task SeedAsync(DateTimeOffset testDate, int? retry = 0)
        {
            _logger.LogInformation($"Seeding data - testDate: {testDate}");
            _logger.LogInformation($"DbContext Type: {_context.Database.ProviderName}");

            _testDate = testDate;
            int retryForAvailability = retry.Value;
            try
            {
                if (_context.IsRealDatabase())
                {
                    // apply migrations if connecting to a SQL database
                    _context.Database.Migrate();
                }

                if (_context != null && _context.Organizations != null && CreateOrganisations != null)
                {
                    if (!await _context.Organizations.AnyAsync())
                    {
                        var organisations = CreateOrganisations();
                        await _context.Organizations.AddRangeAsync(organisations);
                        await _context.SaveChangesAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                if (retryForAvailability < 1)
                {
                    retryForAvailability++;
                    _logger.LogError(ex.Message);
                    await SeedAsync(_testDate, retryForAvailability);
                }
                throw;
            }

            await _context.SaveChangesAsync();
        }

        private List<Organization> CreateOrganisations()
        {
            var result = new List<Organization>
            {
                Organisation1,
                Organisation2,
                Organisation3,
                Organisation4
            };
            return result;
        }
    }
}
