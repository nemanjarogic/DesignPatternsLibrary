using System.Collections.Generic;
using CommandLibrary.ShoppingCartExample.Models;

namespace CommandLibrary.ShoppingCartExample.Repositories.Common
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();

        Product GetById(string productId);

        int GetStock(string productId);

        void IncreaseStock(string productId, int amount);

        void DecreaseStock(string productId, int amount);
    }
}
