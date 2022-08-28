using CommandLibrary.ShoppingCartExample.Models;

namespace CommandLibrary.ShoppingCartExample.Repositories.Common;

// Please be aware that some of the methods defined here shouldn't really be part of the repository.
public interface IShoppingCartRepository
{
    IEnumerable<(Product Product, int Quantity)> GetAll();
    (Product Product, int Quantity) GetById(string productId);
    bool IsEmpty();
    void Add(Product product);
    void Remove(string productId);
    void IncreaseQuantity(string productId);
    void DecreaseQuantity(string productId);
}
