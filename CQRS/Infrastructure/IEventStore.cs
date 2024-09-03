using CQRS.Events;

namespace CQRS.Infrastructure;

/// <summary>
/// Interface for an event store.
/// </summary>
public interface IEventStore
{
    /// <summary>
    /// Saves events to the event store.
    /// </summary>
    /// <param name="aggregateId">The identifier of the aggregate.</param>
    /// <param name="events">The events to save.</param>
    /// <param name="expectedVersion">The expected version of the aggregate.</param>
    /// <param name="expectedName">The expected name of the aggregate.</param>
    Task SaveEventsAsync(Guid aggregateId, IEnumerable<BaseEvent> events, int expectedVersion, string expectedName);

    /// <summary>
    /// Gets events from the event store.
    /// </summary>
    /// <param name="aggregateId">The identifier of the aggregate.</param>
    /// <returns>The events.</returns>
    Task<List<BaseEvent>> GetEventsAsync(Guid aggregateId);

    /// <summary>
    /// Gets the identifiers of all aggregates in the event store.
    /// </summary>
    Task<List<Guid>> GetAggregateIdsAsync();
}