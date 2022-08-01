using LocalAuthorityInformationServices.SharedKernel;
using LocalAuthorityInformationServices.SharedKernel.Interfaces;
using OrganisationAdmin.Domain.Interfaces.Entities;

namespace OrganisationAdmin.Application.Aggregates;

public class Organisation : BaseEntity<Guid>, IAggregateRoot, IOrganisation
{
    public ICollection<IOrganisation> AssociatedOrganisations { get; set; } = new HashSet<IOrganisation>();

    public ICollection<IContact> OrganisationContacts { get; set; } = new HashSet<IContact>();

    public string Name { get; set; } = String.Empty;

    public string? Description { get; set; } = string.Empty;

    public IOrganisation? ParentOrganisation { get; set; } = default;

    public Guid? ParentOrganisationId { get; set; } = default;

    public Organisation() { } // EF use only
}
