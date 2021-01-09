using CommandLibrary.ShoppingCartExample.Commands.Common;
using CommandLibrary.ShoppingCartExample.Models;
using CommandLibrary.ShoppingCartExample.Repositories.Common;

namespace CommandLibrary.ShoppingCartExample.Commands
{
    public class AddToCartCommand : ICommand
    {
        private readonly Product _product;
        private readonly IProductRepository _productRepository;
        private readonly IShoppingCartRepository _shoppingCartRepository;

        public AddToCartCommand(
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

            return _productRepository.GetStock(_product.ProductId) > 0;
        }

        public void Execute()
        {
            _productRepository.DecreaseStock(_product.ProductId, 1);
            _shoppingCartRepository.Add(_product);
        }

        public void Undo()
        {
            var lineItem = _shoppingCartRepository.GetById(_product.ProductId);

            _productRepository.IncreaseStock(_product.ProductId, lineItem.Quantity);
            _shoppingCartRepository.Remove(_product.ProductId);
        }
    }
}
