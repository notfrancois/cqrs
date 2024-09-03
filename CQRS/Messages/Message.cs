namespace CQRS.Messages;

/// <summary>
/// Base class for messages.
/// </summary>
public abstract class Message
{
    /// <summary>
    /// Gets or sets the identifier of the message.
    /// </summary>
    public Guid Id { get; set; }
}