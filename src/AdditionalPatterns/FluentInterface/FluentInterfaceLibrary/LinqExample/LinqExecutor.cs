using BuildingBlocks;

namespace FluentInterfaceLibrary.LinqExample;

public static class LinqExecutor
{
    public static void Execute()
    {
        ConsoleExtension.WriteSeparator("LINQ example");

        var englishToSerbianDictionary = new Dictionary<string, string>
        {
            {"adventure", "avantura"},
            {"bird", "ptica"},
            {"fish", "riba"},
            {"football", "fudbal"},
            {"programming", "programiranje"},
        };

        DisplayDictionary(englishToSerbianDictionary);

        Console.WriteLine("\nFinding translations for English words containing the letter 'a', sorted by length and displayed in uppercase...");
        FindTranslationsProgressively(englishToSerbianDictionary);
        FindTranslationsUsingFluentInterface(englishToSerbianDictionary);
    }

    private static void DisplayDictionary(Dictionary<string, string> englishToSerbianDictionary)
    {
        Console.WriteLine("\nContent of the dictionary: ");
        foreach (var (englishWord, serbianWord) in englishToSerbianDictionary)
        {
            Console.WriteLine($"{englishWord} - {serbianWord}");
        }
    }

    private static void FindTranslationsProgressively(Dictionary<string, string> englishToSerbianDictionary)
    {
        var filtered = englishToSerbianDictionary.Where(t => t.Key.Contains("a"));
        var sorted = filtered.OrderBy(t => t.Value.Length);
        var finalTranslations = sorted.Select(t => t.Value.ToUpper());

        Console.WriteLine("\nProgressive translations: ");
        DisplayWords(finalTranslations);
    }

    private static void FindTranslationsUsingFluentInterface(Dictionary<string, string> englishToSerbianDictionary)
    {
        // C# uses fluent programming extensively in LINQ to build queries using "standard query operators".
        var finalTranslations = englishToSerbianDictionary
            .Where(t => t.Key.Contains("a"))
            .OrderBy(t => t.Value.Length)
            .Select(t => t.Value.ToUpper());

        Console.WriteLine("\nFluent interface translations: ");
        DisplayWords(finalTranslations);
    }

    private static void DisplayWords(IEnumerable<string> words)
    {
        foreach (var word in words)
        {
            Console.WriteLine(word);
        }
    }
}