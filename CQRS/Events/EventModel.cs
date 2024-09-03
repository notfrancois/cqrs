using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CQRS.Events;

/// <summary>
/// Represents an event model in the event store.
/// </summary>
public class EventModel
{
    /// <summary>
    /// Gets or sets the unique identifier for the event.
    /// </summary>  
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    /// <summary>
    /// Gets or sets the timestamp for the event.
    /// </summary>
    public DateTime TimeStamp { get; set; }

    /// <summary>
    /// Gets or sets the aggregate identifier for the event.
    /// </summary>
    public Guid AggregateIdentifier { get; set; }

    /// <summary>
    /// Gets or sets the type of the aggregate.
    /// </summary>
    public string AggregateType { get; set; }

    /// <summary>
    /// Gets or sets the version of the event.
    /// </summary>
    public int Version { get; set; }

    /// <summary>
    /// Gets or sets the type of the event.
    /// </summary>
    public string EventType { get; set; }

    /// <summary>
    /// Gets or sets the event data for the event.
    /// </summary>
    public BaseEvent EventData { get; set; }
}