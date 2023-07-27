namespace FigureLib;

public class Circle : Figure
{
    private double radius;

    public double Radius
    {
        set => radius = (value > 0) ? value : throw new ArgumentException("Radius must be positive number");
    }
    
    public override double GetArea()
    {
        return Double.Pi * Double.Pow(radius, 2);
    }

    public Circle(double radius)
    {
        Radius = radius;
    }
}