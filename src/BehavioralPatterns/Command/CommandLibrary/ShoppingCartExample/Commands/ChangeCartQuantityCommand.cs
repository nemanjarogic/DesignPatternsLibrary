using CommandLibrary.ShoppingCartExample.Commands.Common;
using CommandLibrary.ShoppingCartExample.Models;
using CommandLibrary.ShoppingCartExample.Repositories.Common;

namespace CommandLibrary.ShoppingCartExample.Commands
{
    public class ChangeCartQuantityCommand : ICommand
    {
        private readonly Product _product;
        private readonly ChangeCartQuantityOperation _operation;
        private readonly IProductRepository _productRepository;
        private readonly IShoppingCartRepository _shoppingCartRepository;

        public ChangeCartQuantityCommand(
            ChangeCartQuantityOperation operation,
            Product product,
            IProductRepository productRepository,
            IShoppingCartRepository shoppingCartRepository)
        {
            _operation = operation;
            _product = product;
            _productRepository = productRepository;
            _shoppingCartRepository = shoppingCartRepository;
        }

        public bool CanExecute()
        {
            return _operation switch
            {
                ChangeCartQuantityOperation.Increase => (_productRepository.GetStock(_product.ProductId) - 1) >= 0,
                ChangeCartQuantityOperation.Decrease => _shoppingCartRepository.GetById(_product.ProductId).Quantity != 0,
                _ => false,
            };
        }

        public void Execute()
        {
            switch (_operation)
            {
                case ChangeCartQuantityOperation.Increase:
                    _productRepository.DecreaseStock(_product.ProductId, 1);
                    _shoppingCartRepository.IncreaseQuantity(_product.ProductId);
                    break;
                case ChangeCartQuantityOperation.Decrease:
                    _productRepository.IncreaseStock(_product.ProductId, 1);
                    _shoppingCartRepository.DecraseQuantity(_product.ProductId);
                    break;
            }
        }

        public void Undo()
        {
            switch (_operation)
            {
                case ChangeCartQuantityOperation.Increase:
                    _productRepository.IncreaseStock(_product.ProductId, 1);
                    _shoppingCartRepository.DecraseQuantity(_product.ProductId);
                    break;
                case ChangeCartQuantityOperation.Decrease:
                    _productRepository.DecreaseStock(_product.ProductId, 1);
                    _shoppingCartRepository.IncreaseQuantity(_product.ProductId);
                    break;
            }
        }
    }
}
