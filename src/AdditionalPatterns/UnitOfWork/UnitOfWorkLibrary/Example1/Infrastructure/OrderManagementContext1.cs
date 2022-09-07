using Microsoft.EntityFrameworkCore;
using UnitOfWorkLibrary.Domain;

namespace UnitOfWorkLibrary.Example1.Infrastructure;

public class OrderManagementContext1 : DbContext
{
    public DbSet<Customer> Customers => Set<Customer>();
    public DbSet<Order> Orders => Set<Order>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseSqlite("Data Source=storage1.db");
}
