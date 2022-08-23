namespace FacadeLibrary.MortgageExample.Subsystem;

public class Loan
{
    public bool HasBadLoans(Customer customer)
    {
        Console.WriteLine($"Check loans for the customer: {customer.Name}");

        return false;
    }
}
