namespace Seedwork.Entity;

public interface IValueObject {
    IEnumerable<object> GetAtomicValues();
}