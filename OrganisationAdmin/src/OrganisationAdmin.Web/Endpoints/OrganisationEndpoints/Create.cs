using Ardalis.ApiEndpoints;
using Microsoft.AspNetCore.Mvc;
using OrganisationAdmin.Core.OrganisationAggregate;
using OrganisationAdmin.SharedKernel.Interfaces;
using Swashbuckle.AspNetCore.Annotations;

namespace OrganisationAdmin.Web.Endpoints.OrganisationEndpoints;

public class Create : EndpointBaseAsync
    .WithRequest<CreateOrganisationRequest>
    .WithActionResult<CreateOrganisationResponse>
{
  private readonly IRepository<Organisation> _repository;

  public Create(IRepository<Organisation> repository)
  {
    _repository = repository;
  }

  [HttpPost("/Organisation")]
  [SwaggerOperation(
      Summary = "Creates a new Organisation",
      Description = "Creates a new Organisation",
      OperationId = "Organisation.Create",
      Tags = new[] { "OrganisationEndpoints" })
  ]
  public override async Task<ActionResult<CreateOrganisationResponse>> HandleAsync(CreateOrganisationRequest request,
      CancellationToken cancellationToken)
  {
    if (request.Name == null)
    {
      return BadRequest();
    }

    Organisation newOrganisation = new(request.Name, request.Description);

    var createdItem = await _repository.AddAsync(newOrganisation); // TODO: pass cancellation token

    var response = new CreateOrganisationResponse
    (
        id: createdItem.Id,
        name: createdItem.Name
    );

    return Ok(response);
  }
}
