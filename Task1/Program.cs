Console.Write("Введите сумму вклада: ");
if (double.TryParse(Console.ReadLine(), out var depositAmount))
{
    var interestRate = 0.0d;

    switch (depositAmount)
    {
        case < 100:
            interestRate = 0.05d;
            break;
        case >= 100 and <= 200:
            interestRate = 0.07d;
            break;
        case > 200:
            interestRate = 0.10d;
            break;
    }

    var interestAmount = depositAmount * interestRate;
    var totalAmount = depositAmount + interestAmount;

    Console.WriteLine($"Сумма вклада с начисленными процентами: {totalAmount}");
}
else
{
    Console.WriteLine("Неверный ввод. Пожалуйста, введите корректную сумму вклада.");
}