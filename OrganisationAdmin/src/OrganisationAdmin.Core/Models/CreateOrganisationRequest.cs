using OrganisationAdmin.Core.Aggregates;

namespace OrganisationAdmin.Core.Models;

public class CreateOrganisationRequest : BaseResponse
{
    public Organisation Organisation { get; set; } = default!;
}
