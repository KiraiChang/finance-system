using System.Collections.Concurrent;
using SeedWork.Event;

namespace SeedWork.Entity;
public abstract class BaseAggregateRoot<TIdType, TPropType> : BaseEntity<TIdType, BaseAggregateRoot<TIdType, TPropType>>, IAggregateRoot<TIdType>
    where TIdType : struct
    where TPropType : BaseAggregateRoot<TIdType, TPropType>
{
    protected BaseAggregateRoot(TIdType id) : base(id)
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