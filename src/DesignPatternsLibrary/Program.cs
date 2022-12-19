using BuildingBlocks;

namespace DesignPatternsLibrary;

#nullable enable
public class Program
{
    private const string ExitCode = "q";
    private static readonly SortedDictionary<int, PatternExecutor> Executors = PatternExecutorsRegistry.Instance.GetAll();

    private static void Main(string[] args)
    {
        while (!IsTerminationRequested(out string? choice))
        {
            if (IsChoiceUnsupported(choice, out int choiceKey))
            {
                Console.WriteLine("Please choose one of the following options!");
                continue;
            }

            Executors[choiceKey].Execute();
            Console.ReadLine();
        }

        Console.WriteLine("Thank you!");
        Console.ReadLine();
    }

    private static bool IsTerminationRequested(out string? choice)
    {
        ShowAvailableMenuOptions();
        choice = ChooseOneOptionFromMenu();

        return choice is ExitCode;
    }

    private static void ShowAvailableMenuOptions()
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine(Environment.NewLine);

        foreach (var executor in Executors)
        {
            Console.WriteLine($"{executor.Key}. {executor.Value.Name}");
        }

        Console.WriteLine($"{ExitCode}. Quit");
    }

    private static string? ChooseOneOptionFromMenu()
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\nYour choice: ");

        var choice = Console.ReadLine();

        Console.ResetColor();

        return choice;
    }

    private static bool IsChoiceUnsupported(string? choice, out int choiceKey)
    {
        if (choice == null || !int.TryParse(choice, out int key) || !Executors.ContainsKey(key))
        {
            choiceKey = -1;
            return true;
        }

        choiceKey = key;
        return false;
    }
}
