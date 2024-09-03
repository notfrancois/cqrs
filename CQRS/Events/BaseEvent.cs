using CQRS.Messages;
using MongoDB.Bson.Serialization.Attributes;

namespace CQRS.Events;

/// <summary>
/// Abstract base class for events in the CQRS pattern.
/// </summary>
/// <remarks>
/// This class serves as a foundation for all events in the system,
/// providing a common structure for managing events.
/// </remarks>
[BsonDiscriminator(Required = true)]
public abstract class BaseEvent : Message
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BaseEvent"/> class.
    /// </summary>
    /// <param name="type">The type of the event.</param>
    protected BaseEvent(string type)
    {
        Type = type;
    }

    /// <summary>
    /// Gets or sets the version of the event.
    /// </summary>
    public int Version { get; set; }

    /// <summary>
    /// Gets or sets the type of the event.
    /// </summary>
    public string Type { get; set; }

    /// <summary>
    /// Gets or sets the aggregate identifier for the event.
    /// </summary>
    public string Aggregate { get; set; }
}