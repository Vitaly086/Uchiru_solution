var text = Console.ReadLine();

var totalCountPlusMinus = 0;
var countCharactersAfterZero = 0;
var plus = '+';
var minus = '-';


for (var i = 0; i < text.Length; i++)
{
    if (text[i] == plus || text[i] == minus)
    {
        totalCountPlusMinus++;
    }

    if (i < text.Length - 1 && text[i + 1] == '0')
    {
        countCharactersAfterZero++;
    }
}

Console.WriteLine($"{totalCountPlusMinus} {countCharactersAfterZero}");