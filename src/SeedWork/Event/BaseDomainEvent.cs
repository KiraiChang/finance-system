using System;

namespace SeedWork.Event;

/// <summary>
/// DDD domain event
/// </summary>
/// <typeparam name="TValue">type of domain event</typeparam>
public abstract class BaseDomainEvent<TValue> : IDomainEvent where TValue : new()
{
    /// <summary>
    /// domain id
    /// </summary>
    public Guid Id { get; }
    
    /// <inheritdoc cref="IDomainEvent.OccuredOn"/>
    public DateTime OccuredOn { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="BaseDomainEvent{TValue}"/> class.
    /// </summary>
    /// <param name="id">domain id</param>
    /// <param name="occuredOn">occured time</param>
    private BaseDomainEvent(Guid id, DateTime occuredOn)
    {
        Id = id;
        OccuredOn = occuredOn;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BaseDomainEvent{TValue}"/> class.
    /// </summary>
    protected BaseDomainEvent():this(Guid.NewGuid(), DateTime.Now)
    {
    }
}