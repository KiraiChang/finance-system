using System;

namespace Seedwork.Event;
public abstract class BaseDomainEvent : IDomainEvent
{
    public Guid Id { get; }
    public DateTime OccuredOn { get; }

    public BaseDomainEvent(Guid id, DateTime occuredOn)
    {
        Id = id;
        OccuredOn = occuredOn;
    }

    public BaseDomainEvent():this(Guid.NewGuid(), DateTime.Now)
    {
    }
}