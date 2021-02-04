using System;

namespace OrderProcessing
{
    public class Order
    {
        public Guid ProductId { get; set; }

        public decimal UnitPrice { get; set; }

        public int Quantity { get; set; }
    }
}
