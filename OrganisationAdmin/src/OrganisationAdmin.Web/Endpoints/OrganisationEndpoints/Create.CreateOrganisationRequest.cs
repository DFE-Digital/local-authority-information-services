using System.ComponentModel.DataAnnotations;

namespace OrganisationAdmin.Web.Endpoints.OrganisationEndpoints;

public class CreateOrganisationRequest
{
  public const string Route = "/Projects";

  [Required]
  public string? Name { get; set; }

  public string? Description { get; set; }
}
