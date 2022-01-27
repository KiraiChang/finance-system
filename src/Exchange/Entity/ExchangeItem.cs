using SeedWork.Entity;

namespace Exchange.Entity;

public class ExchangeItem : BaseValueObject<ExchangeItem>
{
    public string Id { get; set; } = string.Empty;
    
    public decimal Value { get; set; }
    
    public override IEnumerable<object> GetAtomicValues()
    {
        yield return Id;
        yield return Value;
    }
}