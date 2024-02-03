using Task5.Dtos;
using Task5.Factories;
using Task5.Models;

namespace Task5.Services;

public class FigureService
{
    private readonly FigureFactory _figureFactory;

    public FigureService(FigureFactory figureFactory)
    {
        _figureFactory = figureFactory;
    }

    public List<FigureDto> GetFigures(int figureCount, FigureType type)
    {
        var figures = new List<FigureDto>(figureCount);

        for (int i = 0; i < figureCount; i++)
        {
            var figure = _figureFactory.CreateFigures(type);
            var figureDto = new FigureDto(
                figure.GetInfo(),
                figure.GetArea(),
                figure.GetPerimeter());
            figures.Add(figureDto);
        }

        return figures;
    }
}