namespace Task5.Models;

public class Rectangle : Figure
{
    private readonly double _width;
    private readonly double _height;

    public Rectangle(double width, double height, FigureType type) : base(type)
    {
        _width = width;
        _height = height;
    }

    public override double GetArea()
    {
        return _width * _height;
    }

    public override double GetPerimeter()
    {
        return 2 * (_width + _height);
    }

    public override string GetInfo()
    {
        return $"Type {FigureType}: Width = {_width}, Height = {_height}";
    }
}