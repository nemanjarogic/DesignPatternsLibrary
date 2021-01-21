using System.Linq;
using CommandLibrary.ShoppingCartExample.Commands.Common;
using CommandLibrary.ShoppingCartExample.Repositories.Common;

namespace CommandLibrary.ShoppingCartExample.Commands
{
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

        public bool CanExecute()
        {
            return !_shoppingCartRepository.IsEmpty();
        }

        public void Execute()
        {
            var items = _shoppingCartRepository.GetAll().ToArray();

            foreach (var (Product, Quantity) in items)
            {
                _productRepository.IncreaseStock(Product.ProductId, Quantity);
                _shoppingCartRepository.Remove(Product.ProductId);
            }
        }

        public void Undo()
        {
            // Not implemented
        }
    }
}
