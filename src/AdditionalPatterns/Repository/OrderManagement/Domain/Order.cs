namespace OrderManagement.Domain;

public class Order : Entity
{
    public string Description { get; set; } = string.Empty;
    public string DeliveryAddress { get; set; } = string.Empty;
    public decimal Price { get; set; }
}
