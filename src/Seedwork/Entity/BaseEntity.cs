namespace Seedwork.Entity;
public abstract class BaseEntity<ID, Prop> : IEntity<ID>, IEquatable<BaseEntity<ID, Prop>>
    where ID : struct
    where Prop : BaseEntity<ID, Prop>
{
    public ID EntityId { get; }

    public BaseEntity(ID id)
    {
        EntityId = id;
    }

    private const int HashMultiplier = 31;

    public virtual bool Equals(BaseEntity<ID, Prop>? other)
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
        return this.Equals(obj as BaseEntity<ID, Prop>);
    }

    public override int GetHashCode()
    {
        var hashCode = this.GetType().GetHashCode();

        return (hashCode * HashMultiplier) ^ this.EntityId.GetHashCode();
    }

    public static bool operator ==(BaseEntity<ID, Prop> left, BaseEntity<ID, Prop> right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(BaseEntity<ID, Prop> left, BaseEntity<ID, Prop> right)
    {
        return !(left == right);
    }
}