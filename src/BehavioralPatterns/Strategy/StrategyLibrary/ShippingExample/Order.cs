namespace StrategyLibrary.ShippingExample
{
    public class Order
    {
        public string Description { get; set; }

        public Address Origin { get; set; }

        public Address Destination { get; set; }
    }
}
