using CQRS.Queries;

namespace CQRS.Infrastructure;

/// <summary>
/// Interface for a query dispatcher.
/// </summary>
/// <typeparam name="TEntity">The type of the entity.</typeparam>
public interface IQueryDispatcher<TEntity>
{
    /// <summary>
    /// Registers a handler for a query.
    /// </summary>
    /// <typeparam name="TQuery">The type of the query.</typeparam>
    /// <param name="handler">The handler for the query.</param>
    void RegisterHandler<TQuery>(Func<TQuery, Task<List<TEntity>>> handler) where TQuery : BaseQuery;

    /// <summary>
    /// Sends a query to the dispatcher.
    /// </summary>
    Task<List<TEntity>> SendAsync(BaseQuery query);
}