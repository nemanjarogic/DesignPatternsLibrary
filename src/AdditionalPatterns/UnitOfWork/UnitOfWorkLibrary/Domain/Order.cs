namespace UnitOfWorkLibrary.Domain
{
    public class Order : Entity
    {
        public string Description { get; set; }

        public string DeliveryAddress { get; set; }

        public decimal Price { get; set; }
    }
}
