using CQRS.Events;

namespace CQRS.Domain;

/// <summary>
/// Interface for a repository that manages event stores.
/// </summary>
public interface IEventStoreRepository
{
    Task SaveAsync(EventModel @event);
    Task<List<EventModel>> FindByAggregateId(Guid aggregateId);
    Task<List<EventModel>> FindAllAsync();
}