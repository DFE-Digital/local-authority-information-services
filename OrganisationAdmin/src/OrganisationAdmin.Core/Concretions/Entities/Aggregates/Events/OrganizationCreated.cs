using LocalAuthorityInformationServices.SharedKernel;
using OrganisationAdmin.Core.Interfaces.Entities.Aggregates;

namespace OrganisationAdmin.Core.Concretions.Entities.Aggregates.Events;

public class OrganizationCreated : DomainEventBase
{
    public IOrganization Organization { get; set; }

    public IReview Review { get; set; }

    public OrganizationCreated
    (
        IOrganization organisation,
        IReview review
    )
    {
        Organization = organisation;
        Review = review;
    }
}
