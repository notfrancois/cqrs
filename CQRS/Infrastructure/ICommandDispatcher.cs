using CQRS.Commands;

namespace CQRS.Infrastructure;

/// <summary>
/// Interface for a command dispatcher.
/// </summary>
public interface ICommandDispatcher
{
    /// <summary>
    /// Registers a handler for a command.
    /// </summary>
    /// <typeparam name="T">The type of the command.</typeparam>
    /// <param name="handler">The handler for the command.</param>
    void RegisterHandler<T>(Func<T, Task> handler) where T : BaseCommand;

    /// <summary>
    /// Sends a command to the dispatcher.
    /// </summary>
    Task SendAsync(BaseCommand command);
}