namespace CQRS.Consumers;

/// <summary>
/// Interface for event consumers in the CQRS pattern.
/// </summary>
/// <remarks>
/// Implementations of this interface are responsible for consuming events from a specific topic.
/// </remarks>
public interface IEventConsumer
{
    /// <summary>
    /// Consumes events from the specified topic.
    /// </summary>
    /// <param name="topic">The topic to consume events from.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the operation.</param>
    void Consume(string topic, CancellationToken cancellationToken);
}