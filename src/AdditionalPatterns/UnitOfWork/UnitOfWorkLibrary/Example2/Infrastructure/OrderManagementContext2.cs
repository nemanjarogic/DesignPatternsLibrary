using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UnitOfWorkLibrary.Domain;

namespace UnitOfWorkLibrary.Example2.Infrastructure
{
    public class OrderManagementContext2 : DbContext, IUnitOfWork2
    {
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Orders { get; set; }

        public async Task<bool> SaveChangesAndDispatchDomainEventsAsync(CancellationToken cancellationToken = default)
        {
            // Dispatch domain events or process any additional work before saving changes.
            var writtenEntries = await SaveChangesAsync(cancellationToken);

            return writtenEntries > 0;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=storage2.db");
        }
    }
}
