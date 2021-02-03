using OrderManagement.Domain;
using OrderManagement.Infrastructure.Repositories.Contracts;

namespace OrderManagement.Infrastructure.Repositories
{
    /// <summary>
    /// In real-life examples different repositories might point to different data sources.
    /// </summary>
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(OrderManagementContext context)
            : base(context)
        {
        }
    }
}
