using System;
//using PluralsightDdd.SharedKernel;
//using PluralsightDdd.SharedKernel.Interfaces;
using LocalAuthorityInformationServices.SharedKernel;
using LocalAuthorityInformationServices.SharedKernel.Interfaces;

namespace OrganisationAdmin.Core.Aggregates;

public class Organisation : BaseEntity<Guid>, IAggregateRoot
{
    public ICollection<Organisation> AssociatedOrganisations { get; set; } = new HashSet<Organisation>();

    public ICollection<Contact> Contacts { get; set; } = new List<Service>();

    public string Name { get; set; }

    public string? Description { get; set; } = string.Empty;

    public Organisation? ParentOrganisation { get; set; } = default;

    public Guid? ParentOrganisationId { get; set; } = default;

    public Organisation() {	} // EF use only
}
