using OrderManagement.Infrastructure.Repositories.Contracts;

namespace OrderManagement.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly OrderManagementContext _context;

        public UnitOfWork(OrderManagementContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
