using CommandLibrary.ShoppingCartExample.Commands.Common;
using CommandLibrary.ShoppingCartExample.Models;
using CommandLibrary.ShoppingCartExample.Repositories.Common;

namespace CommandLibrary.ShoppingCartExample.Commands
{
    public class RemoveFromCartCommand : ICommand
    {
        private readonly Product _product;
        private readonly IProductRepository _productRepository;
        private readonly IShoppingCartRepository _shoppingCartRepository;

        public RemoveFromCartCommand(
            Product product,
            IProductRepository productRepository,
            IShoppingCartRepository shoppingCartRepository)
        {
            _product = product;
            _productRepository = productRepository;
            _shoppingCartRepository = shoppingCartRepository;
        }

        public bool CanExecute()
        {
            if (_product == null)
            {
                return false;
            }

            return _shoppingCartRepository.GetById(_product.ProductId).Quantity > 0;
        }

        public void Execute()
        {
            var lineItem = _shoppingCartRepository.GetById(_product.ProductId);

            _productRepository.IncreaseStock(_product.ProductId, lineItem.Quantity);
            _shoppingCartRepository.Remove(_product.ProductId);
        }

        public void Undo()
        {
            // Not implemented
        }
    }
}
