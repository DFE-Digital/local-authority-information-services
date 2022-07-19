
namespace OrganisationAdmin.SharedKernel.Interfaces;

public interface IDomainEventDispatcher
{
  Task DispatchAndClearEvents(IEnumerable<EntityBase<int>> entitiesWithEvents);
  Task DispatchAndClearEvents(IEnumerable<EntityBase<Guid>> entitiesWithEvents);
}
