using Task10.Models;

namespace Task10;

public class FakeDbContext
{
    private static readonly List<DepositModel> _logs = new();

    public void Add(DepositModel depositModel)
    {
        _logs.Add(depositModel);
    }
}