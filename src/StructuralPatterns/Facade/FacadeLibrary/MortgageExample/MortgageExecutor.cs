using System;
using BuildingBlocks;
using FacadeLibrary.MortgageExample.Facade;

namespace FacadeLibrary.MortgageExample
{
    public static class MortgageExecutor
    {
        public static void Execute()
        {
            ConsoleExtension.WriteSeparator("Mortgage example");

            var mortgage = new Mortgage();
            var customerName = "Mario Balotelli";

            // Evaluate mortgage eligibility for the customer.
            bool isEligible = mortgage.IsEligible(customerName, 125000);

            var status = isEligible ? "approved" : "rejected";
            Console.WriteLine($"Mortgage for {customerName} has been {status}.");
        }
    }
}
