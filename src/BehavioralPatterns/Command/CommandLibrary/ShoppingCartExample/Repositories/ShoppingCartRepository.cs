using System.Collections.Generic;
using CommandLibrary.ShoppingCartExample.Models;
using CommandLibrary.ShoppingCartExample.Repositories.Common;

namespace CommandLibrary.ShoppingCartExample.Repositories
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        private readonly Dictionary<string, (Product Product, int Quantity)> _lineItems;

        public ShoppingCartRepository()
        {
            _lineItems = new Dictionary<string, (Product Product, int Quantity)>();
        }

        public IEnumerable<(Product Product, int Quantity)> GetAll()
        {
            return _lineItems.Values;
        }

        public (Product Product, int Quantity) GetById(string productId)
        {
            if (_lineItems.TryGetValue(productId, out (Product Product, int Quantity) lineItem))
            {
                return lineItem;
            }

            return (default, default);
        }

        public bool IsEmpty()
        {
            return _lineItems.Count == 0;
        }

        public void Add(Product product)
        {
            if (_lineItems.ContainsKey(product.ProductId))
            {
                IncreaseQuantity(product.ProductId);
                return;
            }

            _lineItems[product.ProductId] = (product, 1);
        }

        public void Remove(string productId)
        {
            if (!_lineItems.ContainsKey(productId))
            {
                throw new KeyNotFoundException($"Product with ID {productId} isn't in cart, please add it first");
            }

            _lineItems.Remove(productId);
        }

        public void IncreaseQuantity(string productId)
        {
            if (!_lineItems.TryGetValue(productId, out (Product Product, int Quantity) lineItem))
            {
                throw new KeyNotFoundException($"Product with ID {productId} isn't in cart, please add it first");
            }

            _lineItems[productId] = (lineItem.Product, lineItem.Quantity + 1);
        }

        public void DecraseQuantity(string productId)
        {
            if (!_lineItems.TryGetValue(productId, out (Product Product, int Quantity) lineItem))
            {
                throw new KeyNotFoundException($"Product with ID {productId} isn't in cart, please add it first");
            }

            _lineItems[productId] = (lineItem.Product, lineItem.Quantity - 1);
        }
    }
}
