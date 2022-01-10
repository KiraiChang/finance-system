using Xunit;
using Seedwork.Entity;
namespace Seedwork.Tests.Entity;

public class BaseEntityMock : BaseEntity<int, BaseEntityMock>
{
    public BaseEntityMock(int id) : base(id)
    {

    }
}

public class BaseEntityTest
{
    [Fact]
    public void DiffValueShouldNotEqual()
    {
        var value1 = new BaseEntityMock(1);
        var value2 = new BaseEntityMock(2);

        Assert.True(value1 != value2, "value1 should not be value2");
    }

    [Fact]
    public void SameValueShouldNotEqual()
    {
        var value1 = new BaseEntityMock(1);
        var value2 = new BaseEntityMock(1);

        Assert.True(value1 == value2, "value1 should be value2");
    }
}