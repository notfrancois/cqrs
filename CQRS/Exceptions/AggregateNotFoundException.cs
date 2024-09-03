namespace CQRS.Exceptions;

/// <summary>
/// Exception thrown when an aggregate is not found.
/// </summary>
public class AggregateNotFoundException(string message) : Exception(message)
{

}