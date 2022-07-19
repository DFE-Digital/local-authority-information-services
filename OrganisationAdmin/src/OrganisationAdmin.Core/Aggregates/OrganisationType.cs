

using PluralsightDdd.SharedKernel;
using PluralsightDdd.SharedKernel.Interfaces;

namespace OrganisationAdmin.Core.Aggregates;

public class OrganisationType : BaseEntity<Guid>, IAggregateRoot
{
    public OrganisationType() { }

    public OrganisationType(
        string name,
        string? description
    )
    {
        Id = Guid.NewGuid();
        Name = name;
        Description = description ?? string.Empty;
    }

    public string Name { get; set; } = String.Empty;

    public string? Description { get; set; } = String.Empty;
}
