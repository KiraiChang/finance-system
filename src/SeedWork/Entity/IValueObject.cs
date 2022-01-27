namespace SeedWork.Entity;

public interface IValueObject {
    IEnumerable<object> GetAtomicValues();
}