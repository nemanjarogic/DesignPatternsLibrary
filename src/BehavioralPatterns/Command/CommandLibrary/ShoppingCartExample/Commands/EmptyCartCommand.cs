using CommandLibrary.ShoppingCartExample.Commands.Common;
using CommandLibrary.ShoppingCartExample.Repositories.Common;

namespace CommandLibrary.ShoppingCartExample.Commands;

public class EmptyCartCommand : ICommand
{
    private readonly IProductRepository _productRepository;
    private readonly IShoppingCartRepository _shoppingCartRepository;

    public EmptyCartCommand(
        IProductRepository productRepository,
        IShoppingCartRepository shoppingCartRepository)
    {
        _productRepository = productRepository;
        _shoppingCartRepository = shoppingCartRepository;
    }

    public bool CanExecute() => !_shoppingCartRepository.IsEmpty();

    public void Execute()
    {
        var items = _shoppingCartRepository.GetAll();

        foreach (var (product, quantity) in items)
        {
            // An alternative approach would be to call RemoveFromCartCommand instead of doing the work manually.
            _productRepository.IncreaseStock(product.ProductId, quantity);
            _shoppingCartRepository.Remove(product.ProductId);
        }
    }

    public void Undo()
    {
        // Not implemented.
    }
}
