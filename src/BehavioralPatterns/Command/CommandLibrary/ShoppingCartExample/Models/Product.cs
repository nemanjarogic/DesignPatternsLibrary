namespace CommandLibrary.ShoppingCartExample.Models
{
    public class Product
    {
        public Product(string productId, string name, decimal price)
        {
            ProductId = productId;
            Name = name;
            Price = price;
        }

        public string ProductId { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}
