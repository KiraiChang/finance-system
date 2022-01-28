using SeedWork.Entity;

namespace Exchange.Entity;

/// <summary>
/// exchange item
/// </summary>
public class ExchangeItem : BaseValueObject<ExchangeItem>
{
    /// <summary>
    /// item id
    /// </summary>
    public string Id { get; set; } = string.Empty;
    
    /// <summary>
    /// item value
    /// </summary>
    public decimal Value { get; set; }
    
    /// <inheritdoc cref="IValueObject.GetAtomicValues"/>
    public override IEnumerable<object> GetAtomicValues()
    {
        yield return Id;
        yield return Value;
    }
}