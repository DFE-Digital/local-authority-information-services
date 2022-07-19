using OrganisationAdmin.Core.Aggregates;

namespace OrganisationAdmin.Core.Models;

public  class CreateOrganisationResponse : BaseResponse
{
    public Organisation? Organisation { get; set; }
    public CreateOrganisationResponse(Guid correlationId) : base(correlationId)
    {
    }

    public CreateOrganisationResponse()
    {
    }
}
