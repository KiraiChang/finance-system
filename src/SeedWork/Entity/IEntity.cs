namespace SeedWork.Entity;
/// <summary>
/// DDD entity interface
/// </summary>
/// <typeparam name="TIdType">type of entity id</typeparam>
public interface IEntity<out TIdType> where TIdType : struct
{
    /// <summary>
    /// Entity Id
    /// </summary>
    TIdType EntityId { get; }
}