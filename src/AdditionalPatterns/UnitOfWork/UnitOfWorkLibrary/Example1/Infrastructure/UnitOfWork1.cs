using UnitOfWorkLibrary.Domain;
using UnitOfWorkLibrary.Example1.Infrastructure.Repositories.Contracts;

namespace UnitOfWorkLibrary.Example1.Infrastructure
{
    /// <summary>
    /// The unit of work class serves one purpose:
    /// to make sure that when you use multiple repositories, they share a single database context.
    /// That way, when a unit of work is complete you can call the SaveChanges method on that instance
    /// of the context and be assured that all related changes will be coordinated.
    /// </summary>
    /// </summary>
    public class UnitOfWork1 : IUnitOfWork1
    {
        private readonly OrderManagementContext1 _context;
        private IRepository1<Customer> _customerRepository;
        private IRepository1<Order> _orderRepository;

        public UnitOfWork1(OrderManagementContext1 context)
        {
            _context = context;
        }

        public IRepository1<Customer> CustomerRepository
        {
            get
            {
                if (_customerRepository == null)
                {
                    _customerRepository = new Repository1<Customer>(_context);
                }

                return _customerRepository;
            }
        }

        public IRepository1<Order> OrderRepository
        {
            get
            {
                if (_orderRepository == null)
                {
                    _orderRepository = new Repository1<Order>(_context);
                }

                return _orderRepository;
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
