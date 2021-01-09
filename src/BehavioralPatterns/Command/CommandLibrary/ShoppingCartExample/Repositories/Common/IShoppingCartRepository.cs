using System.Collections.Generic;
using CommandLibrary.ShoppingCartExample.Models;

namespace CommandLibrary.ShoppingCartExample.Repositories.Common
{
    public interface IShoppingCartRepository
    {
        IEnumerable<(Product Product, int Quantity)> GetAll();

        (Product Product, int Quantity) GetById(string productId);

        bool IsEmpty();

        void Add(Product product);

        void Remove(string productId);

        void IncreaseQuantity(string productId);

        void DecraseQuantity(string productId);
    }
}
