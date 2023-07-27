namespace FigureLib;

public class Triangle : Figure
{
    private double sideA, sideB, sideC;
    
    public double A
    {
        set => sideA = (value > 0) ? value : throw new ArgumentException("Length of side A must be positive");
    }
    
    public double B
    {
        set => sideB = (value > 0) ? value : throw new ArgumentException("Length of side B must be positive");
    }
    
    public double C
    {
        set => sideC = (value > 0) ? value : throw new ArgumentException("Length of side C must be positive");
    }
    

    public override double GetArea()
    {
        double halfPerimeter = (sideA + sideB + sideC) / 2.0;;
        return Double.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));
    }

    public bool IsRight()
    {
        double max = new[] { sideA, sideB, sideC }.Max();
        if (sideA*sideA + sideB*sideB + sideC*sideC - max*max - max*max == 0)
            return true;
        return false;
    }
    
    // Don't consider degeneracy
    public void ExistenceСheck()
    {
        if (!(sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA))
        {
            throw new ArgumentException("Triangle with given sides does not exist.");
        }
    }
    
    public Triangle(int a, int b, int c)
    {
        A = a;
        B = b;
        C = c;
        ExistenceСheck();
    }
}