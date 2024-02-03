using Microsoft.AspNetCore.Mvc;
using Task10.Models;
using Task10.Services;

namespace Task10.Controllers;

// Используя веб апи в будущем можно добавить приложения для других платформ с таким же функционалом.
[Route("api/Bank")]
[ApiController]
public class BankApiController : ControllerBase
{
    private readonly DepositCalculatorService _depositCalculatorService;

    public BankApiController(DepositCalculatorService depositCalculatorService)
    {
        _depositCalculatorService = depositCalculatorService;
    }

    [HttpPost("CalculateDeposit")]
    public ActionResult<OperationResult<decimal>> CalculateDeposit(DepositModel depositModel)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var result = _depositCalculatorService.CalculateFinalAmount(depositModel);
        return Ok(result);
    }
}