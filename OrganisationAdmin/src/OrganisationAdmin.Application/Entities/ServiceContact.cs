using OrganisationAdmin.Application.Aggregates;

namespace OrganisationAdmin.Application.Entities;

public class ServiceContact
{
    public Guid ServiceId { get; set; }

    public Guid ContactId { get; set; }

    public Tenent Tenent { get; set; } = new Tenent();

    public Service? Service { get; set; }

    public Contact? Contact { get; set; }
}
