namespace SeedWork.Event;

/// <summary>
/// DDD domain event interface
/// </summary>
public interface IDomainEvent
{
    /// <summary>
    /// domain occured time
    /// </summary>
    DateTime OccuredOn { get; }
}