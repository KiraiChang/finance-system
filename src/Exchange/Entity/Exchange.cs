using SeedWork.Entity;

namespace Exchange.Entity;

public class Exchange : BaseAggregateRoot<DateTime, Exchange>
{
    public IList<ExchangeItem> Data { get; set; } = new List<ExchangeItem>();
    
    public Exchange(DateTime id) : base(id.Date)
    {
    }

    public Exchange() : base(DateTime.Now.Date)
    {
        
    }
}