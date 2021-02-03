using OrderManagement.Domain;

namespace OrderManagement.Infrastructure.Repositories.Contracts
{
    public interface IOrderRepository : IRepository<Order>
    {
        Order GetTheMostExpensive();
    }
}
