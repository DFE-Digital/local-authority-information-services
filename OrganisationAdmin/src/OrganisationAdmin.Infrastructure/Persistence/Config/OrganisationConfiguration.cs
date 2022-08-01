using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrganisationAdmin.Core.Concretions.Entities.Aggregates;

namespace OrganisationAdmin.Infrastructure.Persistence.Config
{
    public class OrganisationConfiguration : IEntityTypeConfiguration<Organization>
    {
        public void Configure(EntityTypeBuilder<Organization> builder)
        {
            builder.Property(p => p.Id).ValueGeneratedNever();
        }
    }
}
