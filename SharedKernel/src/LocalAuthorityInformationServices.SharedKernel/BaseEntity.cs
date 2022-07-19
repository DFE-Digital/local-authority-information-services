namespace LocalAuthorityInformationServices.SharedKernel;

/// <summary>
/// Base types for all Entities which track state using a given Id.
/// </summary>
public abstract class BaseEntity<TId>
{
    private readonly IList<BaseDomainEvent> _events = new List<BaseDomainEvent>();

    public TId Id { get; set; } = default!;

    public List<BaseDomainEvent> Events
    {
        get { return (List<BaseDomainEvent>)_events; }
    }
}
