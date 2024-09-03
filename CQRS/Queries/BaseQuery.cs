namespace CQRS.Queries;

/// <summary>
/// Abstract base class for queries in the CQRS pattern.
/// </summary>
/// <remarks>
/// This class serves as a foundation for all queries in the system,
/// providing a common structure for read operations.
/// </remarks>
public abstract class BaseQuery
{
    /// <summary>
    /// Gets or sets the query parameters.
    /// </summary>
    public Dictionary<string, object> Parameters { get; set; } = new Dictionary<string, object>();

    /// <summary>
    /// Gets or sets the query result.
    /// </summary>
    public object? Result { get; set; }

    /// <summary>
    /// Executes the query and returns the result.
    /// </summary>
    /// <returns>The query result.</returns>
    public abstract object Execute();

    /// <summary>
    /// Validates the query parameters.
    /// </summary>
    /// <returns>True if the parameters are valid, false otherwise.</returns>
    public abstract bool Validate();
}