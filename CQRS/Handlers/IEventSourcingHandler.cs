using CQRS.Domain;

namespace CQRS.Handlers;

/// <summary>
/// Interface for an event sourcing handler.
/// </summary>
/// <typeparam name="T">The type of the aggregate root.</typeparam>
public interface IEventSourcingHandler<T>
{
    /// <summary>
    /// Gets the aggregate root by its identifier.
    /// </summary>
    /// <param name="aggregateId">The identifier of the aggregate root.</param>
    /// <returns>The aggregate root.</returns>
    Task<T> GetByIdAsync(Guid aggregateId);

    /// <summary>
    /// Saves the aggregate root to the event store.
    /// </summary>
    Task<bool> SaveAsync(AggregateRoot aggregate);
}