using System.Globalization;
using Task10.Models;

namespace Task10.Services;

public class DepositCalculatorService
{
    private readonly DepositLoggingService _depositLoggingService;
    private readonly double _interestRate;

    public DepositCalculatorService(IConfiguration configuration, DepositLoggingService depositLoggingService)
    {
        _depositLoggingService = depositLoggingService;
        var interestRateString = configuration["InterestRate"];
        _interestRate = double.Parse(interestRateString, CultureInfo.InvariantCulture);
    }


    public OperationResult<double> CalculateFinalAmount(DepositModel depositModel)
    {
        try
        {
            var finalAmount = depositModel.InitialAmount;
            for (var i = 0; i < depositModel.NumberOfMonths; i++)
            {
                finalAmount += finalAmount * _interestRate / 100;
            }

            _depositLoggingService.Log(depositModel);
            return OperationResult<double>.CreateSuccessResult(Math.Round(finalAmount, 4));
        }
        catch (OverflowException)
        {
            return OperationResult<double>.CreateFailure("Введены неккоректные значения.");
        }
    }

}