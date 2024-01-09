namespace MindBox.Geometry;

public abstract class FigureBase
{
    public abstract string Title { get; }
    protected abstract double GetArea();
    
    public static double CalculateArea(FigureBase figure)
    {
        return figure.GetArea();
    }
}