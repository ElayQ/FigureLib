using FigureLib;

public class TriangleTest
{
    [Theory]
    [InlineData(6, 3, 4, 5)]
    [InlineData(51.999399034988855, 12, 17, 28)]
    [InlineData(1946.0359708905692, 115, 34, 123)]
    public void GetArea_ExistentTriangle(double expected, int sideA, int sideB, int sideC)
    {
        var testTriangle = new Triangle(sideA, sideB, sideC);
        Assert.Equal(expected, testTriangle.GetArea());
    }
    
    [Theory]
    [InlineData( 6, 2, 9)]
    [InlineData( 1, 1, 2)]
    [InlineData(1, 117, 28)]
    public void GetArea_UnexistentTriangle(int sideA, int sideB, int sideC)
    {
        Action act = () => new Triangle(sideA, sideB, sideC);

        var ex = Assert.Throws<ArgumentException>(act);
        Assert.Equal("Triangle with given sides does not exist.", ex.Message);
    }
    
    [Theory]
    [InlineData(true, 3, 4, 5)]
    [InlineData(true, 7, 24, 25)]
    [InlineData(true, 68, 285, 293)]
    [InlineData(false, 3, 24, 25)]
    [InlineData(false, 11, 28, 18)]
    public void IsRight(bool expected, int sideA, int sideB, int sideC)
    {
        var testTriangle = new Triangle(sideA, sideB, sideC);
        Assert.Equal(expected, testTriangle.IsRight());
    }

    [Theory]
    [InlineData(0, 1, 2)]
    [InlineData(-9, 3, 6)]
    [InlineData(0, -10, -1000)]
    [InlineData(-9, 2, -18)]
    public void UnexpectedSideALength(int sideA, int sideB, int sideC)
    {
        Action act = () => new Triangle(sideA, sideB, sideC);

        var ex = Assert.Throws<ArgumentException>(act);
        Assert.Equal("Length of side A must be positive", ex.Message);
    }
    
    [Theory]
    [InlineData(1, 0, 2)]
    [InlineData(1, -9, 6)]
    [InlineData(1, -9, -112)]
    public void UnexpectedSideBLength(int sideA, int sideB, int sideC)
    {
        Action act = () => new Triangle(sideA, sideB, sideC);

        var ex = Assert.Throws<ArgumentException>(act);
        Assert.Equal("Length of side B must be positive", ex.Message);
    }
    
    [Theory]
    [InlineData(1, 3, 0)]
    [InlineData(1, 3, -9)]
    public void UnexpectedSideCLength(int sideA, int sideB, int sideC)
    {
        Action act = () => new Triangle(sideA, sideB, sideC);

        var ex = Assert.Throws<ArgumentException>(act);
        Assert.Equal("Length of side C must be positive", ex.Message);
    }
}