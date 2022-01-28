using SeedWork.Entity;

namespace Exchange.Entity;

/// <summary>
/// exchange aggregate root 
/// </summary>
public class Exchange : BaseAggregateRoot<DateTime, Exchange>
{
    /// <summary>
    /// list of exchange item
    /// </summary>
    public IList<ExchangeItem> Data { get; set; } = new List<ExchangeItem>();
    
    /// <summary>
    /// Initializes a new instance of the <see cref="Exchange"/> class.
    /// </summary>
    /// <param name="id">entity id</param>
    public Exchange(DateTime id) : base(id.Date)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Exchange"/> class.
    /// </summary>
    public Exchange() : base(DateTime.Now.Date)
    {
        
    }
}