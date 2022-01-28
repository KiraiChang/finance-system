using SeedWork.Event;

namespace SeedWork.Entity;

/// <summary>
/// DDD aggregate root interface
/// </summary>
/// <typeparam name="TIdType">entity id type</typeparam>
public interface IAggregateRoot<out TIdType> : IEntity<TIdType> where TIdType : struct
{
    /// <summary>
    /// aggregate root type
    /// </summary>
    string RootType { get; }

    /// <summary>
    /// add domain event
    /// </summary>
    /// <param name="event">domain event</param>
    void AddEvent(IDomainEvent @event);
}