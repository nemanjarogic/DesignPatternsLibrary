namespace StrategyLibrary.ShippingExample;

public class Order
{
    public Order(string description, Address origin, Address destination)
    {
        Description = description;
        Origin = origin;
        Destination = destination;
    }

    public string Description { get; }
    public Address Origin { get; }
    public Address Destination { get; }
}
