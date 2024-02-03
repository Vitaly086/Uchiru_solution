using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Task5.Models;
using Task5.Services;

namespace Task5.Controllers;

[ApiController]
[Route("figures")]
public class FigureController : ControllerBase
{
    private readonly FigureService _figureService;

    public FigureController(FigureService figureService)
    {
        _figureService = figureService;
    }

    [HttpGet("{figureCount}/{figureType}")]
    public IActionResult GetFiguresByType(int figureCount, FigureType figureType)
    {
        if (figureCount < 1)
        {
            return BadRequest("Invalid figure count. Figure count must be greater than or equal to 1.");
        }

        var figures = _figureService.GetFigures(figureCount, figureType);

        if (!figures.Any())
        {
            return NotFound($"No figures found for type {figureType}.");
        }

        return Ok(figures);
    }
}