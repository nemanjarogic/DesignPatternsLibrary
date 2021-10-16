using System;
using CompositeLibrary.GiftExample.Common;

namespace CompositeLibrary.GiftExample
{
    public class SimpleGift : Gift
    {
        public SimpleGift(string description, decimal price)
            : base(description, price)
        {
        }

        public override decimal CalculatePrice()
        {
            Console.WriteLine($"'{_description}' with the price of {_price:C}");

            return _price;
        }
    }
}
