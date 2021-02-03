using Microsoft.EntityFrameworkCore;
using OrderManagement.Domain;

namespace OrderManagement.Infrastructure
{
    public class OrderManagementContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=storage.db");
        }
    }
}
