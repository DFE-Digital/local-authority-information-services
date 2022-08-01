namespace OrganisationAdmin.Domain.Interfaces.Entities
{
    public interface IContact
    {
        ICollection<ILocation> ContactLocations { get; }
        string? Email { get; }
        string Name { get; }
        string? Title { get; }
        Uri? Website { get; }
    }
}