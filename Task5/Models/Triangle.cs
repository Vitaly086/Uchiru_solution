namespace Task5.Models;

public class Triangle : Figure
{
    private readonly double _sideOne;
    private readonly double _sideTwo;
    private readonly double _sideThree;

    public Triangle(double sideOne, double sideTwo, double sideThree, FigureType type) : base(type)
    {
        _sideOne = sideOne;
        _sideTwo = sideTwo;
        _sideThree = sideThree;
    }

    public override double GetArea()
    {
        var halfPerimeter = GetPerimeter() / 2;
        return Math.Sqrt(halfPerimeter * (halfPerimeter - _sideOne) * (halfPerimeter - _sideTwo) *
                         (halfPerimeter - _sideThree));
    }

    public override double GetPerimeter()
    {
        return _sideOne + _sideTwo + _sideThree;
    }

    public override string GetInfo()
    {
        return
            $"Type {FigureType}: Side 1 = {_sideOne}, Side 2 = {_sideTwo}, Side 3 = {_sideThree}";
    }
}