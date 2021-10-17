using System;
using BuildingBlocks;
using StrategyLibrary.SortingExample.Strategies;
using StrategyLibrary.SortingExample.Strategies.Common;

namespace StrategyLibrary.SortingExample
{
    public static class SortingExecutor
    {
        public static void Execute()
        {
            ConsoleExtension.WriteSeparator("Sorting example");

            ISortStrategy sortStrategy = new SortByFirstName();
            var sortablePersons = new SortablePersons(sortStrategy);

            sortablePersons.Add(new Person("Dennis", "Ritchie", 1941));
            sortablePersons.Add(new Person("Linus", "Torvalds", 1969));
            sortablePersons.Add(new Person("Tim", "Berners-Lee", 1955));
            sortablePersons.Add(new Person("Larry", "Page", 1973));
            sortablePersons.Add(new Person("Anders", "Hejlsberg", 1960));
            sortablePersons.Add(new Person("Bjarne", "Stroustrup", 1950));

            Console.WriteLine("Sorting persons by first name.");
            foreach (Person person in sortablePersons.Sort())
            {
                Console.WriteLine(person.ToString());
            }

            sortablePersons.SortStrategy = new SortByYearOfBirth();

            Console.WriteLine("\nSorting persons by year of birth.");
            foreach (Person person in sortablePersons.Sort())
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
