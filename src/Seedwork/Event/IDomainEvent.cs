namespace Seedwork.Event;
public interface IDomainEvent
{
    DateTime OccuredOn { get; }
}