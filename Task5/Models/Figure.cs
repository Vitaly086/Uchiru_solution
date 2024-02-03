namespace Task5.Models;

public abstract class Figure
{
    protected readonly FigureType FigureType;

    protected Figure(FigureType figureType)
    {
        FigureType = figureType;
    }

    public abstract double GetArea();
    public abstract double GetPerimeter();
    public abstract string GetInfo();
}