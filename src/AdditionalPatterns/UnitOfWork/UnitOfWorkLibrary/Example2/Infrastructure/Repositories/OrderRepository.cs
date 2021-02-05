using System.Linq;
using UnitOfWorkLibrary.Domain;
using UnitOfWorkLibrary.Example2.Infrastructure.Repositories.Contracts;

namespace UnitOfWorkLibrary.Example2.Infrastructure.Repositories
{
    public class OrderRepository : Repository2<Order>, IOrderRepository
    {
        public OrderRepository(OrderManagementContext2 context)
            : base(context)
        {
        }

        public Order GetTheMostExpensive()
        {
            return _context.Orders
                .OrderByDescending(order => order.Price)
                .FirstOrDefault();
        }
    }
}
