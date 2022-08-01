namespace OrganisationAdmin.Domain.Interfaces.Entities
{
    public interface ILocation
    {
        string? AddressLine1 { get; }
        string? AddressLine2 { get; }
        string? County { get; }
        string? Postcode { get; }
        string? TownOrCity { get; }
    }
}