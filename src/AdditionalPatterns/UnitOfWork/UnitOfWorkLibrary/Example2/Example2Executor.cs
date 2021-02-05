using System;
using System.Threading.Tasks;
using BuildingBlocks;
using UnitOfWorkLibrary.Domain;
using UnitOfWorkLibrary.Example2.Controllers;
using UnitOfWorkLibrary.Example2.Infrastructure;
using UnitOfWorkLibrary.Example2.Infrastructure.Repositories;

namespace UnitOfWorkLibrary.Example2
{
    public static class Example2Executor
    {
        /// <summary>
        /// In this example, UnitOfWork is accessed through repositories.
        /// The example is extended with concrete repositories.
        /// If necessary, these repositories could be used in example 1 as well.
        /// This example is inspired by eShopOnContainers (https://github.com/dotnet-architecture/eShopOnContainers).
        /// </summary>
        public static async Task ExecuteAsync()
        {
            ConsoleExtension.WriteSeparator("Example 2");

            await InitializeDatabaseAsync();

            using var context = new OrderManagementContext2();
            var customerRepository = new CustomerRepository(context);
            var orderRepository = new OrderRepository(context);

            var customerController = new CustomerController2(customerRepository);
            var orderController = new OrderController2(orderRepository);

            ShowAllCustomers();
            ShowAllOrders();
            await CreateNewOrderAsync();
            ShowAllOrders();

            void ShowAllCustomers()
            {
                Console.WriteLine("Showing all customers...");
                foreach (var customer in customerController.GetAll())
                {
                    Console.WriteLine($"{customer.FirstName} {customer.LastName}");
                }
            }

            void ShowAllOrders()
            {
                Console.WriteLine("\nShowing all orders...");
                foreach (var order in orderController.GetAll())
                {
                    Console.WriteLine($"{order.Description} with price of {order.Price:C}");
                }
            }

            async Task CreateNewOrderAsync()
            {
                Console.WriteLine("\nCreating new order...");
                await orderController.CreateAsync(3, "PlayStation 5", "Address 3", 600);
            }
        }

        private static async Task InitializeDatabaseAsync()
        {
            using (var context = new OrderManagementContext2())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                var emma = new Customer { Id = 1, FirstName = "Emma", LastName = "Johnson" };
                var marc = new Customer { Id = 2, FirstName = "Marc", LastName = "Milston" };

                var camera = new Order { Id = 1, Description = "Camera", DeliveryAddress = "Address 1", Price = 550 };
                var wallet = new Order { Id = 2, Description = "Wallet", DeliveryAddress = "Address 2", Price = 10 };

                var customerRepository = new CustomerRepository(context);
                var orderRepository = new OrderRepository(context);

                customerRepository.Add(emma);
                customerRepository.Add(marc);
                orderRepository.Add(camera);
                orderRepository.Add(wallet);

                await orderRepository.UnitOfWork.SaveChangesAndDispatchDomainEventsAsync();
            }
        }
    }
}
