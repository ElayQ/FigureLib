using FigureLib;

public class CircleTest
{
    [Theory]
    [InlineData(78.53981633974483, 5)]
    [InlineData(153.93804002589985, 7)]
    [InlineData(314.1592653589793, 10)]
    public void GetAreaExpected(double expected, int radius)
    {
        var testCircle = new Circle(radius);
        Assert.Equal(expected, testCircle.GetArea());
    }
    
    [Theory]
    [InlineData(0)]
    [InlineData(-15)]
    public void GetAreaUnexpected(int radius)
    {
        Action act = () => new Circle(radius);

        var ex = Assert.Throws<ArgumentException>(act);
        Assert.Equal("Radius must be positive number", ex.Message);
    }
}