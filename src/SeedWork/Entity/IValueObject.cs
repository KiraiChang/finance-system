namespace SeedWork.Entity;

/// <summary>
/// DDD value object interface
/// </summary>
public interface IValueObject 
{
    /// <summary>
    /// Get all properties
    /// </summary>
    /// <returns>all properties</returns>
    IEnumerable<object> GetAtomicValues();
}