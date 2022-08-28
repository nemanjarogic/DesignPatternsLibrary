using CommandLibrary.ShoppingCartExample.Models;

namespace CommandLibrary.ShoppingCartExample.Repositories.Common;

// Please be aware that some of the methods defined here shouldn't really be part of the repository.
public interface IProductRepository
{
    IEnumerable<Product> GetAll();
    Product? GetById(string productId);
    int GetStock(string productId);
    void IncreaseStock(string productId, int amount);
    void DecreaseStock(string productId, int amount);
}
