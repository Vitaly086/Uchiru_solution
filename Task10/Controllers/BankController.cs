using Microsoft.AspNetCore.Mvc;
using Task10.Models;
using Task10.Services;
using static Task10.ViewDataConstants;

namespace Task10.Controllers;

public class BankController : Controller
{
    private readonly BankApiService _bankApiService;

    public BankController(BankApiService bankApiService)
    {
        _bankApiService = bankApiService;
    }

    [HttpPost]
    public async Task<IActionResult> CalculateDeposit(DepositModel depositModel)
    {
        if (!ModelState.IsValid)
        {
            return View("Index", depositModel);
        }

        var result = await _bankApiService.CalculateDepositAsync(depositModel);

        if (result.Success)
        {
            ViewData[FINAL_DEPOSIT_AMOUNT] = result.Data;
        }
        else
        {
            ModelState.AddModelError(string.Empty, result.ErrorMessage);
        }

        return View("Index", depositModel);
    }


    public IActionResult Index()
    {
        return View(null);
    }
}