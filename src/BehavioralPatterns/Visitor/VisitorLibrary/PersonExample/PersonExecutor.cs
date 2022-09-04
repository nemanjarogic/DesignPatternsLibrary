using BuildingBlocks;
using VisitorLibrary.PersonExample.Elements;
using VisitorLibrary.PersonExample.Visitors;

namespace VisitorLibrary.PersonExample;

public static class PersonExecutor
{
    public static void Execute()
    {
        ConsoleExtension.WriteSeparator("Person example");

        var person = new Person();
        person.RegisterNewAsset(new BankSavingsAccount { Amount = 1000, MonthlyInterest = 0.01 });
        person.RegisterNewAsset(new BankSavingsAccount { Amount = 2000, MonthlyInterest = 0.02 });
        person.RegisterNewAsset(new RealEstate { EstimatedValue = 87000, MonthlyIncomeFromRenting = 500 });
        person.RegisterNewAsset(new Loan { Owed = 40000, MonthlyPayment = 400 });

        var netWorthVisitor = new NetWorthVisitor();
        person.InspectAssets(netWorthVisitor);
        Console.WriteLine($"Person's net worth is {netWorthVisitor.Total:C}");

        var monthlyIncomeVisitor = new MonthlyIncomeVisitor();
        person.InspectAssets(monthlyIncomeVisitor);
        Console.WriteLine($"Person's monthly income is {monthlyIncomeVisitor.Amount:C}");
    }
}
