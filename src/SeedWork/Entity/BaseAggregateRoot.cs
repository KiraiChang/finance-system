using SeedWork.Event;

namespace SeedWork.Entity;

/// <summary>
/// DDD aggregate root
/// </summary>
/// <typeparam name="TIdType">type of entity id</typeparam>
/// <typeparam name="TPropType">type of entity type</typeparam>
public abstract class BaseAggregateRoot<TIdType, TPropType> : BaseEntity<TIdType, BaseAggregateRoot<TIdType, TPropType>>, IAggregateRoot<TIdType>
    where TIdType : struct
    where TPropType : BaseAggregateRoot<TIdType, TPropType>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BaseAggregateRoot{TIdType, TPropType}"/> class.
    /// </summary>
    /// <param name="id">entity id</param>
    protected BaseAggregateRoot(TIdType id) : base(id)
    {

    }

    /// <inheritdoc cref="IAggregateRoot{TIdType}.RootType"/>
    public string RootType => this?.GetType()?.FullName ?? string.Empty;

    /// <inheritdoc cref="IAggregateRoot{TIdType}.AddEvent(IDomainEvent)"/>
    public void AddEvent(IDomainEvent @event)
    {
        
    }
}