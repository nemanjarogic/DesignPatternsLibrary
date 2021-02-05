using UnitOfWorkLibrary.Domain;
using UnitOfWorkLibrary.Example2.Infrastructure.Repositories.Contracts;

namespace UnitOfWorkLibrary.Example2.Infrastructure.Repositories
{
    public class CustomerRepository : Repository2<Customer>, ICustomerRepository
    {
        public CustomerRepository(OrderManagementContext2 context)
            : base(context)
        {
        }
    }
}
