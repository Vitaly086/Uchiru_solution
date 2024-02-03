using Task5.Models;

namespace Task5.Factories;

public class FigureFactory
{
    private readonly FigureDimensionsMock _dimensionsMock = new();

    public Figure CreateFigures(FigureType figureType)
    {
        Figure figure = figureType switch
        {
            FigureType.Triangle => GenerateRandomTriangle(figureType),
            FigureType.Circle => GenerateRandomCircle(figureType),
            FigureType.Rectangle => GenerateRandomRectangle(figureType),
            _ => throw new ArgumentException("Неподдерживаемый тип фигуры")
        };

        return figure;
    }

    private Rectangle GenerateRandomRectangle(FigureType figureType)
    {
        var dimensions = _dimensionsMock.GetRandomRectangleDimensions();
        return new Rectangle(dimensions.Width, dimensions.Height, figureType);
    }

    private Circle GenerateRandomCircle(FigureType figureType)
    {
        var dimensions = _dimensionsMock.GetRandomCircleDimensions();
        return new Circle(dimensions.Radius, figureType);
    }

    private Triangle GenerateRandomTriangle(FigureType figureType)
    {
        var dimensions = _dimensionsMock.GetRandomTriangleDimensions();
        return new Triangle(dimensions.SideA, dimensions.SideB, dimensions.SideC, figureType);
    }
}