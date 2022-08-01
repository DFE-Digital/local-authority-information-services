namespace OrganisationAdmin.Application.Aggregates;
public class Tenent
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string Name { get; set; } = string.Empty;

    public string? Description { get; set; }

    public Tenent() { } // EF use only
}
