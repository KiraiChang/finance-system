using System;

namespace SeedWork.Event;
public abstract class BaseDomainEvent<TValue> : IDomainEvent where TValue : new()
{
    public Guid Id { get; }
    public DateTime OccuredOn { get; }
    public TValue Data { get; }

    protected BaseDomainEvent(Guid id, DateTime occuredOn, TValue data)
    {
        Id = id;
        OccuredOn = occuredOn;
        Data = data;
    }

    protected BaseDomainEvent():this(Guid.NewGuid(), DateTime.Now, new TValue())
    {
    }
}