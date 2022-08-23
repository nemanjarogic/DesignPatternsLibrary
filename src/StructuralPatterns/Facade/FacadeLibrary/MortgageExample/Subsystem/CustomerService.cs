namespace FacadeLibrary.MortgageExample.Subsystem;

public class CustomerService
{
    // Naive implementation.
    // In a real life scenario we would need some customer registry.
    // There may be multiple customers with the same name.
    public Customer Find(string name) =>
        new() { Name = name };
}
