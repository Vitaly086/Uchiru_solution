namespace Task5.Factories;

public class FigureDimensionsMock
{
    private readonly Random _randomGenerator = new();

    private readonly List<TriangleDimensions> _triangleDimensions = new()
    {
        new TriangleDimensions { SideA = 3.5, SideB = 4.2, SideC = 5.1 },
        new TriangleDimensions { SideA = 5.5, SideB = 6.4, SideC = 7.3 },
        new TriangleDimensions { SideA = 2.3, SideB = 3.4, SideC = 4.1 },
        new TriangleDimensions { SideA = 6.7, SideB = 7.8, SideC = 8.9 }
    };

    private readonly List<CircleDimensions> _circleDimensions = new()
    {
        new CircleDimensions { Radius = 1.5 },
        new CircleDimensions { Radius = 2.5 },
        new CircleDimensions { Radius = 3.5 },
        new CircleDimensions { Radius = 4.5 }
    };

    private readonly List<RectangleDimensions> _rectangleDimensions = new()
    {
        new RectangleDimensions { Width = 1.2, Height = 2.3 },
        new RectangleDimensions { Width = 3.4, Height = 4.5 },
        new RectangleDimensions { Width = 5.6, Height = 6.7 },
        new RectangleDimensions { Width = 7.8, Height = 8.9 }
    };

    public TriangleDimensions GetRandomTriangleDimensions()
    {
        var index = _randomGenerator.Next(_triangleDimensions.Count);
        return _triangleDimensions[index];
    }

    public CircleDimensions GetRandomCircleDimensions()
    {
        var index = _randomGenerator.Next(_circleDimensions.Count);
        return _circleDimensions[index];
    }

    public RectangleDimensions GetRandomRectangleDimensions()
    {
        var index = _randomGenerator.Next(_rectangleDimensions.Count);
        return _rectangleDimensions[index];
    }
}

public struct RectangleDimensions
{
    public double Width;
    public double Height;
}

public struct CircleDimensions
{
    public double Radius;
}

public struct TriangleDimensions
{
    public double SideA;
    public double SideB;
    public double SideC;
}