using System;
using BuildingBlocks;
using VisitorLibrary.PersonExample.Elements;
using VisitorLibrary.PersonExample.Visitors;

namespace VisitorLibrary.PersonExample
{
    public static class PersonExecutor
    {
        public static void Execute()
        {
            ConsoleExtension.WriteSeparator("Person example");

            var person = new Person();
            person.Assets.Add(new BankAccount { Amount = 1000, MonthlyInterest = 0.01 });
            person.Assets.Add(new BankAccount { Amount = 2000, MonthlyInterest = 0.02 });
            person.Assets.Add(new RealEstate { EstimatedValue = 77000, MonthlyRent = 500 });
            person.Assets.Add(new Loan { Owed = 40000, MonthlyPayment = 400 });

            var netWorthVisitor = new NetWorthVisitor();
            var incomeVisitor = new IncomeVisitor();

            person.Accept(netWorthVisitor);
            Console.WriteLine($"Person's net worth is {netWorthVisitor.Total:C}");

            person.Accept(incomeVisitor);
            Console.WriteLine($"Person's monthly income is {incomeVisitor.Amount:C}");
        }
    }
}
