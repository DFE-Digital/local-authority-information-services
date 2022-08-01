using LocalAuthorityInformationServices.SharedKernel;
using LocalAuthorityInformationServices.SharedKernel.Interfaces;
using OrganisationAdmin.Core.Interfaces.Entities.Aggregates;

namespace OrganisationAdmin.Core.Concretions.Entities.Aggregates;

public class Organization : EntityBase<Guid>, IOrganization, IAggregateRoot 
{
    // Public Properties
    public string Name { get; private set; } = string.Empty;

    public string? Description { get; private set; } = string.Empty;

    public string? Logo { get; private set; } = string.Empty;

    public string? Uri { get; private set; } = string.Empty;

    public string? Url { get; private set; } = string.Empty;

    //public virtual ICollection<Review>? Reviews { get; private set; } = new HashSet<Review>();

    //public virtual ICollection<Service>? Services { get; private set; } = new HashSet<Service>();

    // Public Constructors
    public Organization
    (
        //string id,
        string? name,
        string? description,
        string? logo,
        string? uri,
        string? url
        //ICollection<Review>? reviews,
        //ICollection<Service>? services
    )
    {
        //Id = id;
        Name = name;
        Description = description;
        Logo = logo;
        Uri = uri;
        Url = url;
        //Reviews = reviews;
        //Services = services;
    }

    // Private Properties

    // Private Members

    // Private Constructors
    private Organization() { } // EF use only, EF needs a parameterless constructor


    //private readonly List<IContact> _organisationContacts = new List<IContact>();
    //public IEnumerable<IContact> OrganisatinContacts => _organisationContacts.AsReadOnly();

    //public void AddOrganisationContact(IContact contact)
    //{
    //    Guard.Against.Null(contact, nameof(contact));
    //    _organisationContacts.Add(contact);
    //}
}

