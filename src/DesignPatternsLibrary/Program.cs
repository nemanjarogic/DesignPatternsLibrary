using System;
using System.Collections.Generic;
using DesignPatternsLibrary.PatternExecutors;

namespace DesignPatternsLibrary
{
    public class Program
    {
        private static readonly string ExitCode = "q";
        private static readonly SortedDictionary<int, PatternExecutor> Executors = PatternExecutorsRegistry.Instance.GetAll();

        private static void Main(string[] args)
        {
            while (IsChoiceDifferentFromExitCode(out string choice))
            {
                if (IsChoiceUnsupported(choice, out int choiceKey))
                {
                    Console.WriteLine("Please choose one of the following options!");
                    continue;
                }

                Executors[choiceKey].Execute();
            }

            Console.WriteLine("Thank you!");
            Console.ReadLine();
        }

        private static bool IsChoiceDifferentFromExitCode(out string choice)
        {
            ShowAvailableMenuOptions();
            choice = ChooseOneOptionFromMenu();

            return !choice.Equals(ExitCode);
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

        private static string ChooseOneOptionFromMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\nYour choice: ");

            var choice = Console.ReadLine();

            Console.ResetColor();

            return choice;
        }

        private static bool IsChoiceUnsupported(string choice, out int choiceKey)
        {
            if (!int.TryParse(choice, out int key) || !Executors.ContainsKey(key))
            {
                choiceKey = -1;
                return true;
            }

            choiceKey = key;
            return false;
        }
    }
}
