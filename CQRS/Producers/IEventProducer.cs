using CQRS.Events;
using CQRS.Messages;

namespace CQRS.Producers;

/// <summary>
/// Interface for an event producer.
/// </summary>
public interface IEventProducer
{
    /// <summary>
    /// Produces an event to a specified topic.
    /// </summary>
    /// <typeparam name="T">The type of the event.</typeparam>
    /// <param name="topic">The topic to produce the event to.</param>
    /// <param name="event">The event to produce.</param>
    Task ProduceAsync<T>(string topic, T @event) where T : BaseEvent;

    /// <summary>
    /// Produces an event to a specified topic.
    /// </summary>
    /// <typeparam name="T">The type of the event.</typeparam>
    /// <param name="topic">The topic to produce the event to.</param>
    /// <param name="event">The event to produce.</param>
    /// <param name="message">The message to produce.</param>
    Task ProduceAsync<T>(string topic, T @event, Message message) where T : BaseEvent;
}