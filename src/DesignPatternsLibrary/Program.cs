using DesignPatternsLibrary.PatternExecutors;
using System;
using System.Collections.Generic;

namespace DesignPatternsLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
			string choice;
			var executors = PatternExecutorsRegistry.Instance.GetAll();

			while (!(choice = SelectFromMenu(executors)).Equals("q"))
			{
                if (!int.TryParse(choice, out int translatedChoice))
                {
                    Console.WriteLine("Please choose one of the following!");
                    continue;
                }

                if (!executors.ContainsKey(translatedChoice))
				{
					Console.WriteLine("Please choose one of the following!");
					continue;
				}

				executors[translatedChoice].Execute();
				
			}

			Console.WriteLine("Thank you!");
			Console.ReadLine();
		}

		static string SelectFromMenu(SortedDictionary<int, PatternExecutor> executors)
		{
			ListAvailableMenuOptions(executors);
			var choice = ChooseOneOption();

			Console.ResetColor();

			return choice;
		}

		static void ListAvailableMenuOptions(SortedDictionary<int, PatternExecutor> executors)
        {
			Console.ForegroundColor = ConsoleColor.DarkGreen;
			Console.WriteLine(Environment.NewLine);

			foreach (var executor in executors)
			{
				Console.WriteLine($"{executor.Key}. {executor.Value.Name}");
			}

			Console.WriteLine("q. Quit");
		}

		static string ChooseOneOption()
        {
			Console.ForegroundColor = ConsoleColor.DarkGray;
			Console.WriteLine($"\n Your choice: ");

			return Console.ReadLine().ToLower();
		}


	}
}
