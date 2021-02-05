using System;
using BuildingBlocks;
using UnitOfWorkLibrary.Domain;
using UnitOfWorkLibrary.Example1.Controllers;
using UnitOfWorkLibrary.Example1.Infrastructure;

namespace UnitOfWorkLibrary.Example1
{
    public static class Example1Executor
    {
        /// <summary>
        /// In example 1, UnitOfWork has access to all repositories (that could be injected through DI)
        /// and repositories are implemented in a generic way without any differences between them.
        /// It would be possible to extend this example and create concrete repositories (like OrderRepository in example 2).
        /// </summary>
        public static void Execute()
        {
            ConsoleExtension.WriteSeparator("Example 1");

            InitializeDatabase();

            using var context = new OrderManagementContext1();
            var unitOfWork = new UnitOfWork1(context);

            var customerController = new CustomerController1(unitOfWork);
            var orderController = new OrderController1(unitOfWork);

            ShowAllCustomers();
            ShowAllOrders();
            CreateNewOrder();
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

            void CreateNewOrder()
            {
                Console.WriteLine("\nCreating new order...");
                orderController.Create(3, "PlayStation 5", "Address 3", 600);
            }
        }

        private static void InitializeDatabase()
        {
            using (var context = new OrderManagementContext1())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                var emma = new Customer { Id = 1, FirstName = "Emma", LastName = "Johnson" };
                var marc = new Customer { Id = 2, FirstName = "Marc", LastName = "Milston" };

                var camera = new Order { Id = 1, Description = "Camera", DeliveryAddress = "Address 1", Price = 550 };
                var wallet = new Order { Id = 2, Description = "Wallet", DeliveryAddress = "Address 2", Price = 10 };

                var unitOfWork = new UnitOfWork1(context);

                unitOfWork.CustomerRepository.Add(emma);
                unitOfWork.CustomerRepository.Add(marc);
                unitOfWork.OrderRepository.Add(camera);
                unitOfWork.OrderRepository.Add(wallet);

                unitOfWork.SaveChanges();
            }
        }
    }
}
