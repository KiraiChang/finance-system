using System.Collections.Concurrent;
using Seedwork.Event;

namespace Seedwork.Entity;
public class BaseAggregateRoot<ID, Type> : BaseEntity<ID, BaseAggregateRoot<ID, Type>>, IAggregateRoot<ID>
    where ID : struct
    where Type : BaseAggregateRoot<ID, Type>
{

    public BaseAggregateRoot(ID id) : base(id)
    {

    }

    public string RootType => this?.GetType()?.FullName ?? string.Empty;

    private readonly ConcurrentStack<IDomainEvent> _events = new ConcurrentStack<IDomainEvent>();
    public IEnumerable<IDomainEvent> Events => _events;

    public void AddEvent(IDomainEvent @event)
    {
        _events.Push(@event);
    }

    public void ClearEvents()
    {
        _events.Clear();
    }
}