using BuildingBlocks;
using RulesLibrary.Common;

namespace RulesLibrary.RulesExample;

public static class RulesExecutor
{
    public static void Execute()
    {
        ConsoleExtension.WriteSeparator("Rules example");

        var customer = new Customer(
            dateOfBirth: DateTime.Now.AddYears(-70),
            dateOfFirstPurchase: DateTime.Today.AddYears(-6),
            isVeteran: false);

        var discountCalculator = new DiscountCalculator();
        var discountPercentage = discountCalculator.Calculate(customer);

        Console.WriteLine($"The customer can get a {discountPercentage:P2} discount on any product.");
    }
}
