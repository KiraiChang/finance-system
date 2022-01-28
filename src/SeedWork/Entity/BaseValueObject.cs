using System;
using System.Collections.Generic;

namespace SeedWork.Entity;

/// <summary>
/// DDD value object
/// </summary>
/// <typeparam name="T">type of value object</typeparam>
public abstract class BaseValueObject<T> : IValueObject, IEquatable<BaseValueObject<T>>
    where T : BaseValueObject<T>
{
    /// <summary>
    /// check object is equals
    /// </summary>
    /// <param name="other">be check object</param>
    /// <returns>this and other is equal</returns>
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

    /// <inheritdoc cref="object.Equals(object?)"/>
    public override bool Equals(object? obj)
    {
        return this.Equals(obj as BaseValueObject<T>);
    }

    /// <inheritdoc cref="object.GetHashCode"/>
    public override int GetHashCode()
    {
        return this.GetAtomicValues()
            .Select(x => x != null ? x.GetHashCode() : 0)
            .Aggregate((x, y) => x ^ y);
    }

    /// <summary>
    /// BaseValueObject operator == check left and right is equals
    /// </summary>
    /// <param name="left">left object</param>
    /// <param name="right">right object</param>
    /// <returns>left and right is equals</returns>
    public static bool operator ==(BaseValueObject<T> left, BaseValueObject<T> right)
    {
        return Equals(left, right);
    }

    /// <summary>
    /// BaseValueObject operator != check left and right is not equals
    /// </summary>
    /// <param name="left">left object</param>
    /// <param name="right">right object</param>
    /// <returns>left and right is not equals</returns>
    public static bool operator !=(BaseValueObject<T> left, BaseValueObject<T> right)
    {
        return !(left == right);
    }

    /// <inheritdoc cref="IValueObject.GetAtomicValues"/>
    public abstract IEnumerable<object> GetAtomicValues();
}