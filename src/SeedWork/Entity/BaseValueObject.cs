using System;
using System.Collections.Generic;

namespace SeedWork.Entity;

public abstract class BaseValueObject<T> : IValueObject, IEquatable<BaseValueObject<T>>
    where T : BaseValueObject<T>
{
    public virtual bool Equals(BaseValueObject<T>? other)
    {
        if (ReferenceEquals(other, null))
        {
            return false;
        }

        using var thisValues = this.GetAtomicValues().GetEnumerator();
        using var otherValues = other.GetAtomicValues().GetEnumerator();
        while (thisValues.MoveNext() && otherValues.MoveNext())
        {
            if (ReferenceEquals(thisValues.Current, null) ^
                ReferenceEquals(otherValues.Current, null))
            {
                return false;
            }

            if (thisValues.Current != null &&
                !thisValues.Current.Equals(otherValues.Current))
            {
                return false;
            }
        }
                
        return !thisValues.MoveNext() && !otherValues.MoveNext();
    }

    public override bool Equals(object? obj)
    {
        return this.Equals(obj as BaseValueObject<T>);
    }

    public override int GetHashCode()
    {
        return this.GetAtomicValues()
            .Select(x => x != null ? x.GetHashCode() : 0)
            .Aggregate((x, y) => x ^ y);
    }

    public static bool operator ==(BaseValueObject<T> left, BaseValueObject<T> right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(BaseValueObject<T> left, BaseValueObject<T> right)
    {
        return !(left == right);
    }

    public abstract IEnumerable<object> GetAtomicValues();
}