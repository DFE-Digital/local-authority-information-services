using Microsoft.EntityFrameworkCore;

namespace OrganisationAdmin.Infrastructure.Persistence.Repository
{
    public static class DatabaseProviderHelpers
    {
        public static bool IsRealDatabase(this DbContext context)
        {
            return context.Database.ProviderName.Contains("SqlServer");
        }
    }
}
