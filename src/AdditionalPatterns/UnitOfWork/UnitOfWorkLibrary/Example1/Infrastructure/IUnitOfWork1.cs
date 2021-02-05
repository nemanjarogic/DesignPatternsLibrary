using UnitOfWorkLibrary.Domain;
using UnitOfWorkLibrary.Example1.Infrastructure.Repositories.Contracts;

namespace UnitOfWorkLibrary.Example1.Infrastructure
{
    public interface IUnitOfWork1
    {
        IRepository1<Customer> CustomerRepository { get; }

        IRepository1<Order> OrderRepository { get; }

        void SaveChanges();
    }
}
