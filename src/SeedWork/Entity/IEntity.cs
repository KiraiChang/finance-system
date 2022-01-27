namespace SeedWork.Entity;
public interface IEntity<out TIdType>
{
    TIdType EntityId { get; }
}