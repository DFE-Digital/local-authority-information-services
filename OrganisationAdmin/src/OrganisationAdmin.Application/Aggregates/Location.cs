using LocalAuthorityInformationServices.SharedKernel;
using LocalAuthorityInformationServices.SharedKernel.Interfaces;
using OrganisationAdmin.Domain.Interfaces.Entities;

namespace OrganisationAdmin.Application.Aggregates;

public class Location : BaseEntity<Guid>, IAggregateRoot, ILocation
{
    public string? AddressLine1 { get; private set; }

    public string? AddressLine2 { get; private set; }

    public string? TownOrCity { get; private set; }

    public string? County { get; private set; }

    public string? Postcode { get; private set; }

    public Location() { } // EF use only

    public Location
    (
        Guid id,
        string? addressLine1,
        string? addressLine2,
        string? townOrCity,
        string? county,
        string? postcode
    )
    {
        Id = id;
        AddressLine1 = addressLine1;
        AddressLine2 = addressLine2;
        TownOrCity = townOrCity;
        County = county;
        Postcode = postcode;
    }
}
