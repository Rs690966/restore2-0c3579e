using Math = restore2.Api.Math;

namespace restore2.Test;

public class MathTest
{
    [Fact]
    public void SumOfTwoNumbers()
    {
        //Arrange
        var math = new Math();
        //Act
        var result = math.Sum(2, 2);
        //Assert
        Assert.Equal(4,result);
    }
}