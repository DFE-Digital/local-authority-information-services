using LocalAuthorityInformationServices.SharedKernel;
using LocalAuthorityInformationServices.SharedKernel.Interfaces;
using OrganisationAdmin.Application.Entities;

namespace OrganisationAdmin.Application.Aggregates;

public class Service : BaseEntity<Guid>, IAggregateRoot
{
    public string Name { get; set; } = string.Empty;

    public string? Description { get; set; }

    public ICollection<Contact> Contacts { get; set; } = new HashSet<Contact>();
    public ICollection<ServiceContact>? ServiceContacts { get; set; } = new HashSet<ServiceContact>();

    public Organisation? Organisation { get; set; }

    public Service() { } // EF use only
}
