using UnitOfWorkLibrary.Domain;

namespace UnitOfWorkLibrary.Example2.Infrastructure.Repositories.Contracts
{
    public interface IOrderRepository : IRepository2<Order>
    {
        Order GetTheMostExpensive();
    }
}
