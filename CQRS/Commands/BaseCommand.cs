using CQRS.Messages;

namespace CQRS.Commands;

/// <summary>
/// Abstract base class for commands in the CQRS pattern.
/// </summary>
/// <remarks>
/// This class serves as a foundation for all commands in the system,
/// providing a common structure for write operations.
/// </remarks>
public abstract class BaseCommand : Message
{
}