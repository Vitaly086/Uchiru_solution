using Microsoft.AspNetCore.Mvc;

namespace Task4.Controllers;

[ApiController]
[Route("trains")]
public class TrainController : ControllerBase
{
    private static readonly List<Train> _trains = new()
    {
        new Train { Destination = "Москва", TrainNumber = 5, DepartureTime = "17:00" },
        new Train { Destination = "Анапа", TrainNumber = 1, DepartureTime = "11:30" },
        new Train { Destination = "Саратов", TrainNumber = 8, DepartureTime = "09:00" },
        new Train { Destination = "Мурманск", TrainNumber = 15, DepartureTime = "22:20" },
        new Train { Destination = "Екатеринбург", TrainNumber = 4, DepartureTime = "11:00" }
    };


    [HttpGet("GetTrainByNumber/{trainNumber}")]
    public IActionResult GetTrainByNumber([FromRoute] int trainNumber)
    {
        var train = _trains.FirstOrDefault(t => t.TrainNumber == trainNumber);

        return train != null ? Ok(train) : NotFound($"Train with {trainNumber} not found");
    }

    [HttpGet("SortTrainsByDestination")]
    public IActionResult SortTrainsByDestination()
    {
        var sortedTrains = _trains
            .OrderBy(t => t.Destination)
            .ThenBy(t => t.DepartureTime)
            .ToList();

        return Ok(sortedTrains);
    }

    [HttpGet("FilterTrainsByDepartureTime")]
    public IActionResult FilterTrainsByDepartureTime()
    {
        var currentTime = DateTime.Now;
        var futureTrains = _trains.Where(t =>
        {
            if (DateTime.TryParse(t.DepartureTime, out var departureTime))
            {
                return departureTime > currentTime;
            }

            return false;
        }).ToList();

        return Ok(futureTrains);
    }
}