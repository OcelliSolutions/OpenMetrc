namespace OpenMetrc.Scraper;

internal static class StringService
{
    // convert a string to title case.
    internal static IEnumerable<char> CharsToTitleCase(string s)
    {
        var newWord = true;
        foreach (var c in s)
        {
            if (newWord)
            {
                yield return char.ToUpper(c);
                newWord = false;
            }
            else
            {
                yield return c;
            }

            if (c == ' ') newWord = true;
        }
    }

    //static string TitleCase(string input) => Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(input);
    internal static string TitleCase(string input) => new(CharsToTitleCase(input).ToArray());
}