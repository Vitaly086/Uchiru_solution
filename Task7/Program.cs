using System.Text;
using System.Text.RegularExpressions;

internal class Program
{
    public static void Main(string[] args)
    {
        var text = Console.ReadLine();

        var maskedText1 = HideEmailAndURLWithoutRegular(text!);
        var maskedText2 = HideEmailAndURLWithRegular(text!);

        Console.WriteLine(maskedText1);
        Console.WriteLine(maskedText2);
    }

    private static string HideEmailAndURLWithRegular(string text)
    {
        string emailPattern = @"\b\S+@\S+\.\S+\b";
        string urlPattern = @"\b(https?://|www\.)\S*\b";
        string combinedPattern = $"{emailPattern}|{urlPattern}";
        var maskedText =
            Regex.Replace(text, combinedPattern, match => new string('*', match.Length), RegexOptions.IgnoreCase);

        return maskedText;
    }

    private static string HideEmailAndURLWithoutRegular(string text)
    {
        var words = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        var stringBuilder = new StringBuilder();

        foreach (var word in words)
        {
            var trimmedWord = word.TrimEnd('!', '.', ',', ';', ':', '?');
            if (IsEmail(word) || IsURL(word))
            {
                var maskedWord = new string('*', trimmedWord.Length);
                stringBuilder.Append(maskedWord + word.Substring(trimmedWord.Length) + " ");
            }
            else
            {
                stringBuilder.Append(word + " ");
            }
        }

        return stringBuilder.ToString();
    }

    private static bool IsURL(string word)
    {
        return word.StartsWith("www") || word.StartsWith("http://") || word.StartsWith("https://");
    }

    private static bool IsEmail(string word)
    {
        return word.Contains('@') && word.Contains('.');
    }
}