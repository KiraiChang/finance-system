using System;

namespace Seedwork.Event;
public abstract class DomainEvent
{
    public Guid Id { get; }
    public DateTime OccuredOn { get; }

    protected DomainEvent(Guid id, DateTime occuredOn)
    {
        Id = id;
        OccuredOn = occuredOn;
    }

    protected DomainEvent():this(Guid.NewGuid(), DateTime.Now)
    {
    }
}