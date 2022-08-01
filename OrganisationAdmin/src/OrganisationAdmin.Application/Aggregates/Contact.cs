using LocalAuthorityInformationServices.SharedKernel;
using LocalAuthorityInformationServices.SharedKernel.Interfaces;
using OrganisationAdmin.Domain.Interfaces.Entities;

namespace OrganisationAdmin.Application.Aggregates;

public class Contact : BaseEntity<Guid>, IAggregateRoot, IContact
{
    public string Name { get; private set; } = string.Empty;

    public string? Title { get; private set; } = default!;

    public string? Email { get; private set; } = default!;

    public Uri? Website { get; private set; } = default!;

#pragma warning disable CS8766 // Nullability of reference types in return type doesn't match implicitly implemented member (possibly because of nullability attributes).
    public ICollection<ILocation>? ContactLocations { get; private set; } = new HashSet<ILocation>();
#pragma warning restore CS8766 // Nullability of reference types in return type doesn't match implicitly implemented member (possibly because of nullability attributes).

    private Contact() { } // EF use only

    public Contact
    (
        Guid id,
        string name,
        string? title = default!,
        string? email = default!,
        Uri? website = default!,
        ICollection<ILocation>? contactLocations = default!
    )
    {
        Id = id;
        Name = name;
        Title = title;
        Email = email;
        Website = website;
        ContactLocations = contactLocations ?? new HashSet<ILocation>();
    }
}
