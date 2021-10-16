using System;
using System.Collections.Generic;
using CompositeLibrary.GiftExample.Common;

namespace CompositeLibrary.GiftExample
{
    public class CompositeGift : Gift, IGiftOperations
    {
        /// <summary>
        /// This collection can store simple as well as composite gifts.
        /// </summary>
        private List<Gift> _gifts;

        public CompositeGift(string description)
            : base(description, 0)
        {
            _gifts = new List<Gift>();
        }

        public void Add(Gift gift)
        {
            _gifts.Add(gift);
        }

        public void Remove(Gift gift)
        {
            // Consider using HashSet or Dictionary if you need remove item from a collection.
            _gifts.Remove(gift);
        }

        public override decimal CalculatePrice()
        {
            decimal totalPrice = 0;

            Console.WriteLine($"'{_description}' contains the following products with prices:");
            foreach (var gift in _gifts)
            {
                totalPrice += gift.CalculatePrice();
            }

            return totalPrice;
        }
    }
}
