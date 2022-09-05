using BuildingBlocks;
using OrderManagement.Controllers;
using OrderManagement.Domain;
using OrderManagement.Infrastructure;
using OrderManagement.Infrastructure.Repositories;

namespace OrderManagement;

public class Executor : PatternExecutor, IDisposable
{
    private readonly OrderManagementContext _context;
    private readonly CustomerRepository _customerRepository;
    private readonly OrderRepository _orderRepository;
    private readonly UnitOfWork _unitOfWork;
    private readonly CustomerController _customerController;
    private readonly OrderController _orderController;

    private bool _isDisposed;

    public override string Name => "Repository - Data Access Pattern";

    public Executor()
    {
        _context = new OrderManagementContext();
        _customerRepository = new CustomerRepository(_context);
        _orderRepository = new OrderRepository(_context);
        _unitOfWork = new UnitOfWork(_context);

        _customerController = new CustomerController(_customerRepository);
        _orderController = new OrderController(_orderRepository, _unitOfWork);
    }

    public override void Execute()
    {
        InitializeDatabase();

        ShowAllCustomers();
        ShowAllOrders();
        CreateNewOrder();
        ShowAllOrders();
    }

    private void InitializeDatabase()
    {
        _context.Database.EnsureDeleted();
        _context.Database.EnsureCreated();

        var emma = new Customer { Id = 1, FirstName = "Emma", LastName = "Johnson" };
        var marc = new Customer { Id = 2, FirstName = "Marc", LastName = "Milston" };

        _customerRepository.Add(emma);
        _customerRepository.Add(marc);

        var camera = new Order { Id = 1, Description = "Camera", DeliveryAddress = "Address 1", Price = 550 };
        var wallet = new Order { Id = 2, Description = "Wallet", DeliveryAddress = "Address 2", Price = 10 };

        _orderRepository.Add(camera);
        _orderRepository.Add(wallet);

        _unitOfWork.Commit();
    }

    private void ShowAllCustomers()
    {
        Console.WriteLine("Showing all customers...");
        foreach (var customer in _customerController.GetAll())
        {
            Console.WriteLine($"{customer.FirstName} {customer.LastName}");
        }
    }

    private void ShowAllOrders()
    {
        Console.WriteLine("\nShowing all orders...");
        foreach (var order in _orderController.GetAll())
        {
            Console.WriteLine($"{order.Description} with price of {order.Price:C}");
        }
    }

    private void CreateNewOrder()
    {
        Console.WriteLine("\nCreating new order...");
        _orderController.Create(3, "PlayStation 5", "Address 3", 600);
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (_isDisposed)
        {
            return;
        }

        if (disposing)
        {
            _context.Dispose();
        }

        _isDisposed = true;
    }
}
