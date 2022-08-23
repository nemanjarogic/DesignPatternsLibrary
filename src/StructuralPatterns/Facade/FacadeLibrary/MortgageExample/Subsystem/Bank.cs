namespace FacadeLibrary.MortgageExample.Subsystem;

public class Bank
{
    public bool IsUntrustworthy(Customer customer, decimal loanAmount)
    {
        Console.WriteLine($"Check credit-worthiness for the customer: {customer.Name}");

        return false;
    }
}
