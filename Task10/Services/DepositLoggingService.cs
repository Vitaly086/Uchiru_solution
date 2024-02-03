using Task10.Models;

namespace Task10.Services;

// Сервис для инкапсулирования логики работы с базой данных и фейкового логирования данных депозита.
public class DepositLoggingService
{
    private readonly FakeDbContext _dbContext;

    public DepositLoggingService(FakeDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Log(DepositModel depositModel)
    {
        Console.WriteLine($"InitialAmount: {depositModel.InitialAmount}, NumberOfMonths: {depositModel.NumberOfMonths}");
        _dbContext.Add(depositModel);
    }
}