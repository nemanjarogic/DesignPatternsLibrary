using System;
using DesignPatternsLibrary.PatternExecutors;
using OrderManagement.Controllers;
using OrderManagement.Domain;
using OrderManagement.Infrastructure;
using OrderManagement.Infrastructure.Repositories;

namespace OrderManagement
{
    public class Executor : PatternExecutor
    {
        public override string Name => "Repository - Data Access Pattern";

        public override void Execute()
        {
            InitializeDatabase();

            using var context = new OrderManagementContext();
            var customerRepository = new CustomerRepository(context);
            var orderRepository = new OrderRepository(context);

            var customerController = new CustomerController(customerRepository);
            var orderController = new OrderController(orderRepository);

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

        private void InitializeDatabase()
        {
            using (var context = new OrderManagementContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                var emma = new Customer { Id = 1, FirstName = "Emma", LastName = "Johnson" };
                var marc = new Customer { Id = 2, FirstName = "Marc", LastName = "Milston" };

                var camera = new Order { Id = 1, Description = "Camera", DeliveryAddress = "Address 1", Price = 550 };
                var wallet = new Order { Id = 2, Description = "Wallet", DeliveryAddress = "Address 2", Price = 10 };

                var customerRepository = new CustomerRepository(context);
                customerRepository.Add(emma);
                customerRepository.Add(marc);
                customerRepository.SaveChanges();

                var orderRepository = new OrderRepository(context);
                orderRepository.Add(camera);
                orderRepository.Add(wallet);
                orderRepository.SaveChanges();
            }
        }
    }
}
