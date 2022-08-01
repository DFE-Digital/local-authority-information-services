namespace OrganisationAdmin.Domain.Interfaces.Entities
{
    public interface IOrganisation
    {
        ICollection<IOrganisation> AssociatedOrganisations { get; set; }

        string? Description { get; set; }

        string Name { get; set; }

        ICollection<IContact> OrganisationContacts { get; set; }

        IOrganisation? ParentOrganisation { get; set; }

        Guid? ParentOrganisationId { get; set; }
    }
}