namespace OrderProcessing;

public class Order
{
    public Guid ProductId { get; init; }
    public decimal UnitPrice { get; init; }
    public int Quantity { get; init; }
}
