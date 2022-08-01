using OrganisationAdmin.Core.Concretions.Entities.Aggregates;

namespace OrganisationAdmin.Core.Interfaces.Entities.Aggregates
{
    public interface IOrganization
    {
        string? Name { get; }

        string? Description { get; }

        string? Logo { get; }

        //ICollection<Review>? Reviews { get; }

        //ICollection<Service>? Services { get; }

        string? Uri { get; }

        string? Url { get; }
    }
}