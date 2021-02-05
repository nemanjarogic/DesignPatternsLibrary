using Microsoft.EntityFrameworkCore;
using UnitOfWorkLibrary.Domain;

namespace UnitOfWorkLibrary.Example1.Infrastructure
{
    public class OrderManagementContext1 : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=storage1.db");
        }
    }
}
