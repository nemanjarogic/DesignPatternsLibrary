using System;
using BuildingBlocks;
using CommandLibrary.ShoppingCartExample.Commands;
using CommandLibrary.ShoppingCartExample.Models;
using CommandLibrary.ShoppingCartExample.Repositories;
using CommandLibrary.ShoppingCartExample.Repositories.Common;

namespace CommandLibrary.ShoppingCartExample
{
    public static class ShoppingCartExecutor
    {
        public static void Execute()
        {
            ConsoleExtension.WriteSeparator("Shopping cart example");

            var productRepository = new ProductRepository();
            var shoppingCartRepository = new ShoppingCartRepository();

            var product = productRepository.GetById("XI-NOTE10");

            var addToCartCommand = new AddToCartCommand(
                product,
                productRepository,
                shoppingCartRepository);

            var increaseQuantityCommand = new ChangeCartQuantityCommand(
                ChangeCartQuantityOperation.Increase,
                product,
                productRepository,
                shoppingCartRepository);

            var manager = new CommandManager();
            manager.Invoke(addToCartCommand);
            manager.Invoke(increaseQuantityCommand);
            manager.Invoke(increaseQuantityCommand);
            manager.Invoke(increaseQuantityCommand);
            manager.Invoke(increaseQuantityCommand);

            PrintCart(shoppingCartRepository);

            manager.Undo();

            PrintCart(shoppingCartRepository);
        }

        private static void PrintCart(IShoppingCartRepository shoppingCartRepository)
        {
            var totalPrice = 0m;

            foreach (var lineItem in shoppingCartRepository.GetAll())
            {
                var price = lineItem.Product.Price * lineItem.Quantity;

                Console.WriteLine(
                    $"\nProduct [ " +
                    $"Name: {lineItem.Product.Name}, " +
                    $"Price: {lineItem.Product.Price:C}, " +
                    $"Quantity: {lineItem.Quantity} ] " +
                    $"-> Price: {price:C}");

                totalPrice += price;
            }

            Console.WriteLine($"Total price: {totalPrice:C}");
        }
    }
}
