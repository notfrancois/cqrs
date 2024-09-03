using CQRS.Events;

namespace CQRS.Domain;

/// <summary>
/// Abstract base class for aggregate roots in the CQRS pattern.
/// </summary>
/// <remarks>
/// This class serves as a foundation for all aggregate roots in the system,
/// providing a common structure for managing entities and their events.
/// </remarks>
public abstract class AggregateRoot
{
    /// <summary>
    /// Gets or sets the unique identifier for the aggregate root.
    /// </summary>
    protected Guid _id;

    /// <summary>
    /// Gets or sets the version of the aggregate root.
    /// </summary>
    public int Version { get; set; } = -1;

    /// <summary>
    /// Gets the name of the aggregate root.
    /// </summary>
    public string AggregateName => this.GetType().Name;

    /// <summary>
    /// Gets the uncommitted changes for the aggregate root.
    /// </summary>
    private readonly IList<BaseEvent> _changes = new List<BaseEvent>();

    /// <summary>
    /// Gets the unique identifier for the aggregate root.
    /// </summary>
    public Guid Id => _id;

    public IEnumerable<BaseEvent> GetUncommittedChanges()
    {
        return _changes;
    }

    /// <summary>
    /// Marks the changes as committed.
    /// </summary>
    public void MarkChangesAsCommitted()
    {
        _changes.Clear();
    }

    /// <summary>
    /// Applies a change to the aggregate root.
    /// </summary>
    /// <param name="event">The event to apply.</param>
    /// <param name="isNew">True if the event is new, false otherwise.</param>
    private void ApplyChange(BaseEvent @event, bool isNew)
    {
        var method = this.GetType().GetMethod("Apply", new Type[] { @event.GetType() });
        if (method == null)
        {
            throw new ArgumentNullException(nameof(method),
                $"The apply method was not found in the aggregate for {@event.GetType().Name}!");
        }

        method.Invoke(this, new object[] { @event });

        if (isNew)
        {
            _changes.Add(@event);
        }
    }

    /// <summary>
    /// Raises an event for the aggregate root.
    /// </summary>
    /// <param name="event">The event to raise.</param>
    protected void RaiseEvent(BaseEvent @event)
    {
        ApplyChange(@event, true);
    }

    /// <summary>
    /// Replays events for the aggregate root.
    /// </summary>
    /// <param name="events">The events to replay.</param>
    public void ReplayEvents(IEnumerable<BaseEvent> events)
    {
        foreach (var @event in events)
        {
            ApplyChange(@event, false);
        }
    }
}