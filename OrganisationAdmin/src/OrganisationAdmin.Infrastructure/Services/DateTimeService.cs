using OrganisationAdmin.Core.Interfaces.Services.Infrastructure.OperatingSystem;

namespace OrganisationAdmin.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
