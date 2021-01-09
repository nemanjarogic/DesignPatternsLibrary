using System;

namespace CommandLibrary.StockExample
{
    public class Stock
    {
        private readonly string _name;
        private readonly int _quantity;

        public Stock(string name, int quantity)
        {
            _name = name;
            _quantity = quantity;
        }

        public void Buy()
        {
            Console.WriteLine($"Stock [ Name: {_name}, Quantity: {_quantity} ] is bought.");
        }

        public void Sell()
        {
            Console.WriteLine($"Stock [ Name: {_name}, Quantity: {_quantity} ] is sold.");
        }
    }
}
