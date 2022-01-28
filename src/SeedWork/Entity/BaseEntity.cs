namespace SeedWork.Entity;

/// <summary>
/// DDD entity
/// </summary>
/// <typeparam name="TIdType">type of entity id</typeparam>
/// <typeparam name="TPropType">type of entity</typeparam>
public abstract class BaseEntity<TIdType, TPropType> : IEntity<TIdType>, IEquatable<BaseEntity<TIdType, TPropType>>
    where TIdType : struct
    where TPropType : BaseEntity<TIdType, TPropType>
{
    /// <inheritdoc cref="IEntity{TIdType}.EntityId"/>
    public TIdType EntityId { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="BaseEntity{TIdType, TPropType}"/> class.
    /// </summary>
    /// <param name="id">entity id</param>
    protected BaseEntity(TIdType id)
    {
        EntityId = id;
    }

    /// <summary>
    /// const hash multiplier
    /// </summary>
    private const int HashMultiplier = 31;

    /// <summary>
    /// check other is equals this
    /// </summary>
    /// <param name="other">other object</param>
    /// <returns>other is equals this</returns>
    public virtual bool Equals(BaseEntity<TIdType, TPropType>? other)
    {
        if (ReferenceEquals(other, null))
        {
            return false;
        }

        return ReferenceEquals(this, other) || this.EntityId.Equals(other.EntityId);
    }

    /// <inheritdoc cref="object.Equals(object?)"/>
    public override bool Equals(object? obj)
    {
        return this.Equals(obj as BaseEntity<TIdType, TPropType>);
    }

    /// <inheritdoc cref="object.GetHashCode"/>
    public override int GetHashCode()
    {
        var hashCode = this.GetType().GetHashCode();

        return (hashCode * HashMultiplier) ^ this.EntityId.GetHashCode();
    }

    /// <summary>
    /// BaseEntity operator == check left and right is equals
    /// </summary>
    /// <param name="left">left object</param>
    /// <param name="right">right object</param>
    /// <returns>left and right is equals</returns>
    public static bool operator ==(BaseEntity<TIdType, TPropType> left, BaseEntity<TIdType, TPropType> right)
    {
        return Equals(left, right);
    }

    /// <summary>
    /// BaseEntity operator != check left and right is not equals
    /// </summary>
    /// <param name="left">left object</param>
    /// <param name="right">right object</param>
    /// <returns>left and right is not equals</returns>
    public static bool operator !=(BaseEntity<TIdType, TPropType> left, BaseEntity<TIdType, TPropType> right)
    {
        return !(left == right);
    }
}