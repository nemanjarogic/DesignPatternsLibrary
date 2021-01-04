using System;
using System.Collections.Generic;
using BuildingBlocks;

namespace CompositeLibrary.ShareholdersExample.Before
{
    public static class BeforeExecutor
    {
        public static void Execute()
        {
            ConsoleExtension.WriteSeparator("Shareholders example - before");

            int totalNumberOfShares = 1000;
            Console.WriteLine($"Total number of shares is: {totalNumberOfShares}!");

            var james = new Person { Name = "James" };
            var mary = new Person { Name = "Mary" };
            var emily = new Person { Name = "Emily" };
            var sophia = new Person { Name = "Sophia" };
            var johan = new Person { Name = "Johan" };
            var nikola = new Person { Name = "Nikola" };
            var frenk = new Person { Name = "Frenk" };

            var bigCorporation = new Corporation
            {
                Name = "Big corporation",
                Shareholders = { james, mary, emily, sophia, johan },
            };

            var independentShareholders = new List<Person> { nikola, frenk };
            var corporations = new List<Corporation> { bigCorporation };

            var totalToSplitBy = independentShareholders.Count + corporations.Count;

            var sharesForEachParty = totalNumberOfShares / totalToSplitBy;
            var remainingShares = totalNumberOfShares % totalToSplitBy;

            // Divide shares between independent shareholders
            foreach (var shareholder in independentShareholders)
            {
                shareholder.NumberOfShares = sharesForEachParty + remainingShares;
                remainingShares = 0;
                shareholder.PrintReport();
            }

            // Divide shares between shareholders within corporation
            foreach (var corporation in corporations)
            {
                var sharesForEachShareholderInCorporation = sharesForEachParty / corporation.Shareholders.Count;
                var remainingSharesForCorporation = sharesForEachParty % corporation.Shareholders.Count;

                foreach (var shareholder in corporation.Shareholders)
                {
                    shareholder.NumberOfShares = sharesForEachShareholderInCorporation + remainingSharesForCorporation;
                    remainingSharesForCorporation = 0;
                    shareholder.PrintReport();
                }
            }
        }
    }
}
