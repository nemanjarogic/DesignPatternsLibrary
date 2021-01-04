using System;
using BuildingBlocks;

namespace CompositeLibrary.ShareholdersExample.After
{
    public static class AfterExecutor
    {
        public static void Execute()
        {
            ConsoleExtension.WriteSeparator("Shareholders example - after");

            int totalNumberOfShares = 1000;
            Console.WriteLine($"Total number of shares is: {totalNumberOfShares}!");

            var james = new Person { Name = "James" };
            var mary = new Person { Name = "Mary" };
            var emily = new Person { Name = "Emily" };
            var sophia = new Person { Name = "Sophia" };
            var johan = new Person { Name = "Johan" };
            var nikola = new Person { Name = "Nikola" };
            var frenk = new Person { Name = "Frenk" };

            var smallCorporation = new Corporation
            {
                Name = "Small corporation",
                Shareholders = { james, mary },
            };

            var bigCorporation = new Corporation
            {
                Name = "Big corporation",
                Shareholders = { smallCorporation, emily, sophia, johan },
            };

            var allShareholders = new Corporation
            {
                Name = "All shareholders",
                Shareholders = { bigCorporation, nikola, frenk },
            };

            allShareholders.NumberOfShares = totalNumberOfShares;
            allShareholders.PrintReport();
        }
    }
}
