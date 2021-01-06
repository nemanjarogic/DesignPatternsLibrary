namespace FacadeLibrary.MortgageExample.Subsystem
{
    public class CustomerService
    {
        public Customer Find(string name)
        {
            // Naive implementation
            // In real life scenario we need to have customer registry
            // There may be multiple customers with the same name
            return new Customer { Name = name };
        }
    }
}
