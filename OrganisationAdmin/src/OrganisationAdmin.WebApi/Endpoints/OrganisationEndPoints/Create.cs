using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using OrganisationAdmin.Core.Aggregates;
using OrganisationAdmin.Core.Models;
using PluralsightDdd.SharedKernel.Interfaces;
using Swashbuckle.AspNetCore.Annotations;

namespace OrganisationAdmin.WebApi.Endpoints.OrganisationEndPoints;

public class Create : BaseAsyncEndpoint
    .WithRequest<CreateOrganisationRequest>
    .WithResponse<CreateOrganisationResponse>
{
    private readonly IRepository<Organisation> _repository;
    

    public Create(IRepository<Organisation> repository)
    {
        _repository = repository;
    }

    [HttpPost("api/Organisation")]
    [SwaggerOperation(
        Summary = "Creates a new Organisation",
        Description = "Creates a new Organisation",
        OperationId = "organisation.create",
        Tags = new[] { "OrganisationEndpoints" })
    ]
    public override async Task<ActionResult<CreateOrganisationResponse>> HandleAsync(CreateOrganisationRequest request, CancellationToken cancellationToken = default)
    {
        var response = new CreateOrganisationResponse(request.CorrelationId);

        var toAdd = await _repository.AddAsync(request.Organisation);
        response.Organisation = toAdd;

        return Ok(response);
    }
}
