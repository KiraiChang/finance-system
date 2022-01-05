namespace Seedwork.Entity;
public abstract class BaseEntity<ID, Prop> where Prop : class
{
    public ID EntityId { get; }
    public Prop Props { get; }

    public BaseEntity(ID id, Prop props)
    {
        EntityId = id;
        Props = props;
    }
}
