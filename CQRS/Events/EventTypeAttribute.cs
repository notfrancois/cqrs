namespace CQRS.Events;

/// <summary>
/// Attribute to specify the name of an event type.
/// </summary>
[AttributeUsage(AttributeTargets.Class, Inherited = false)]
public class EventTypeAttribute : Attribute
{
    /// <summary>
    /// Gets the name of the event type.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="EventTypeAttribute"/> class.
    /// </summary>
    /// <param name="name">The name of the event type.</param>
    public EventTypeAttribute(string name)
    {
        Name = name;
    }
}