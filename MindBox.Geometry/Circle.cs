namespace MindBox.Geometry;

public class Circle : FigureBase
{
    public override string Title => nameof(Circle);

    private readonly double _radius;
    
    public Circle(double radius) 
    {
        if (radius < 0)
            throw new ArgumentException("Something is wrong with the side parameters");

        _radius = radius;
    }

    protected override double GetArea()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}