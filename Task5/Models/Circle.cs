namespace Task5.Models;

public class Circle : Figure
{
    private readonly double _radius;

    public Circle(double radius, FigureType type) : base(type)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }

    public override double GetPerimeter()
    {
        return 2 * Math.PI * _radius;
    }

    public override string GetInfo()
    {
        return $"Type {FigureType}: Radius = {_radius,4}";
    }
}