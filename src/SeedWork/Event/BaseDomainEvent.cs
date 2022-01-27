using System;

namespace SeedWork.Event;
public abstract class BaseDomainEvent : IDomainEvent
{
    public Guid Id { get; }
    public DateTime OccuredOn { get; }

    protected BaseDomainEvent(Guid id, DateTime occuredOn)
    {
        Id = id;
        OccuredOn = occuredOn;
    }

    protected BaseDomainEvent():this(Guid.NewGuid(), DateTime.Now)
    {
    }
}