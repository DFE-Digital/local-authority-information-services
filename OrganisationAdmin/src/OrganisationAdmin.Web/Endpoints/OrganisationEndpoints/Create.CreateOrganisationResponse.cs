namespace OrganisationAdmin.Web.Endpoints.OrganisationEndpoints;

public class CreateOrganisationResponse
{
  public CreateOrganisationResponse(Guid id, string name)
  {
    Id = id;
    Name = name;
  }
  public Guid Id { get; set; }
  public string Name { get; set; }

  public string Description { get; set; }
}
