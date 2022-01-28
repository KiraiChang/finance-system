using System.Collections.Generic;
using Xunit;
using SeedWork.Entity;
namespace SeedWork.Tests.Entity;

public class BaseValueObjectMock : BaseValueObject<BaseValueObjectMock>
{
    public string Name { get; }

    public string Value { get; }

    public BaseValueObjectMock(string name, string value)
    {
        Name = name;
        Value = value;
    }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return Name;
        yield return Value;
    }
}

public class BaseValueObjectTest
{
    [Fact]
    public void DiffValueShouldNotEqual()
    {
        var value1 = new BaseValueObjectMock("Test1", "Value1");
        var value2 = new BaseValueObjectMock("Test2", "Value2");

        Assert.True(value1 != value2, "value1 should not be value2");
    }

    [Fact]
    public void SameValueShouldNotEqual()
    {
        var value1 = new BaseValueObjectMock("Test1", "Value1");
        var value2 = new BaseValueObjectMock("Test1", "Value1");

        Assert.True(value1 == value2, "value1 should be value2");
    }
}