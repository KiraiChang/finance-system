using Seedwork.Event;

namespace Seedwork.Entity;

public interface IAggregateRoot<ID> : IEntity<ID>
{
    string RootType { get; }
    IEnumerable<IDomainEvent> Events { get; }

    void AddEvent(IDomainEvent @event);
    void ClearEvents();
}