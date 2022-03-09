using Xunit;
using myapp.lib;

namespace myapp.test.lib;

public class calculatorTest
{
    [Fact]
    public void Add_Normal()
    {
        var c = new calculator();
        var result = c.Add(1,2);
        Assert.Equal(3, result);
    }
    [Fact]
    public void Add_Normal2()
    {
        var c = new calculator();
        var result = c.Add(1,2);
        Assert.Equal(3, result);
    }
}