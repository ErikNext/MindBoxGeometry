namespace MindBox.Geometry;

public class Triangle : FigureBase
{
    public override string Title => nameof(Triangle);

    private readonly (double A, double B, double C) _sides;
    
    public Triangle(double sideA, double sideB, double sideC)
    {
        if (!SidesValidation(sideA, sideB, sideC))
            throw new ArgumentException("Something is wrong with the side parameters");

        _sides = (sideA, sideB, sideC);
    }

    private bool SidesValidation(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            return false;

        if (sideA + sideB <= sideC|| sideA + sideC <= sideB || sideB + sideC <= sideA)
            return false;

        return true;
    }

    protected override double GetArea()
    {
        var p = (_sides.A + _sides.B + _sides.C) / 2;
        return Math.Sqrt(p * (p - _sides.A) * (p - _sides.B) * (p - _sides.C));
    }
    
    public bool IsRectangular()
    {
        return Math.Pow(_sides.C, 2) == Math.Pow(_sides.A, 2) + Math.Pow(_sides.B, 2);
    }
}