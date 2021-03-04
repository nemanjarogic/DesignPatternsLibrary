using System;
using BuildingBlocks;
using VisitorLibrary.PersonDynamicProgrammingExample.Elements;
using VisitorLibrary.PersonDynamicProgrammingExample.Visitors;

namespace VisitorLibrary.PersonDynamicProgrammingExample
{
    public static class PersonDynamicProgrammingExecutor
    {
        public static void Execute()
        {
            ConsoleExtension.WriteSeparator("Person dynamic programming example");

            var person = new Person();
            person.Assets.Add(new BankAccount { Amount = 1000, MonthlyInterest = 0.01 });
            person.Assets.Add(new BankAccount { Amount = 2000, MonthlyInterest = 0.02 });
            person.Assets.Add(new RealEstate { EstimatedValue = 77000, MonthlyRent = 500 });
            person.Assets.Add(new Loan { Owed = 40000, MonthlyPayment = 400 });

            var netWorthVisitor = new NetWorthVisitor();
            var incomeVisitor = new IncomeVisitor();

            person.InspectAssets(netWorthVisitor);
            Console.WriteLine($"Person's net worth is {netWorthVisitor.Total:C}");

            person.InspectAssets(incomeVisitor);
            Console.WriteLine($"Person's monthly income is {incomeVisitor.Amount:C}");
        }
    }
}
