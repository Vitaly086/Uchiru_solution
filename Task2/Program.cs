int[,,] numbers =
{
    { { 1, 2 }, { 3, 4 } },
    { { 4, 5 }, { 6, 7 } },
    { { 7, 8 }, { 9, 10 } },
    { { 10, 11 }, { 12, 13 } }
};

Console.Write("{");
for (int i = 0; i < numbers.GetLength(0); i++)
{
    Console.Write("{");
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        Console.Write("{");
        for (int k = 0; k < numbers.GetLength(2); k++)
        {
            Console.Write($" {numbers[i, j, k]} ");
            if (k < numbers.GetLength(2) - 1)
            {
                Console.Write(",");
            }
        }

        Console.Write("}");
        if (j < numbers.GetLength(1) - 1)
        {
            Console.Write(" , ");
        }
    }

    Console.Write("}");
    if (i < numbers.GetLength(0) - 1)
    {
        Console.Write(" , ");
    }
}

Console.WriteLine("}");