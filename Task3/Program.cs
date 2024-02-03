var numbers = new[] { 6, 7, 2, 3, 9, 4, 7, 1, 3, 6, 8, 3, 7, 8, 3 };

var minSum = numbers[0] + numbers[1];
var firstIndex = -1;
var secondIndex = -1;

for (var i = 1; i < numbers.Length - 1; i++)
{
    var currentSum = numbers[i] + numbers[i - 1];

    if (currentSum < minSum)
    {
        minSum = currentSum;
        firstIndex = i - 1;
        secondIndex = i;
    }
}

Console.WriteLine($"Первый элемент {numbers[firstIndex]} под индексом {firstIndex}," +
                  $" второй элемент {numbers[secondIndex]} под индексом {secondIndex}," +
                  $" минимальная сумма {minSum}.");