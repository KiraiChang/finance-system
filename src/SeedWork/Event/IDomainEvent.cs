namespace SeedWork.Event;
public interface IDomainEvent
{
    DateTime OccuredOn { get; }
}