using SeedWork.Event;

namespace SeedWork.Entity;

public interface IAggregateRoot<out TIdType> : IEntity<TIdType>
{
    string RootType { get; }
    IEnumerable<IDomainEvent> Events { get; }

    void AddEvent(IDomainEvent @event);
    void ClearEvents();
}