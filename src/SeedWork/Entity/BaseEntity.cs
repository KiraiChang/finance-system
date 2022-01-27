namespace SeedWork.Entity;
public abstract class BaseEntity<TIdType, TPropType> : IEntity<TIdType>, IEquatable<BaseEntity<TIdType, TPropType>>
    where TIdType : struct
    where TPropType : BaseEntity<TIdType, TPropType>
{
    public TIdType EntityId { get; }

    protected BaseEntity(TIdType id)
    {
        EntityId = id;
    }

    private const int HashMultiplier = 31;

    public virtual bool Equals(BaseEntity<TIdType, TPropType>? other)
    {
        if (ReferenceEquals(other, null))
        {
            return false;
        }

        if (ReferenceEquals(this, other))
        {
            return true;
        }

        return this.EntityId.Equals(other.EntityId);
    }

    public override bool Equals(object? obj)
    {
        return this.Equals(obj as BaseEntity<TIdType, TPropType>);
    }

    public override int GetHashCode()
    {
        var hashCode = this.GetType().GetHashCode();

        return (hashCode * HashMultiplier) ^ this.EntityId.GetHashCode();
    }

    public static bool operator ==(BaseEntity<TIdType, TPropType> left, BaseEntity<TIdType, TPropType> right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(BaseEntity<TIdType, TPropType> left, BaseEntity<TIdType, TPropType> right)
    {
        return !(left == right);
    }
}