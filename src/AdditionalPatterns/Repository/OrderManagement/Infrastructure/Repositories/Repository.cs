using OrderManagement.Domain;
using OrderManagement.Infrastructure.Repositories.Contracts;
using System.Linq.Expressions;

namespace OrderManagement.Infrastructure.Repositories;

/// <summary>
/// Repositories completely encapsulates all the minutiae of data access.
/// Typically, data access code is very repetitive, and it's concerned with low-level infrastructure details
/// like opening database connections, managing transactions and so on.
/// We don't want that sort of code duplicated throughout our business logic.
/// What we'd like to do is extract that so that the business logic is just focused on implementing
/// the special algorithms that are crucial to the business.
/// </summary>
/// <typeparam name="T">Entity type.</typeparam>
public abstract class Repository<T> : IRepository<T>
    where T : Entity
{
    protected OrderManagementContext _context;

    protected Repository(OrderManagementContext context)
    {
        _context = context;
    }

    public virtual T Add(T entity) =>
        _context
            .Add(entity)
            .Entity;

    public virtual IEnumerable<T> GetAll() =>
        _context.Set<T>().ToList();

    public virtual IEnumerable<T> Get(Expression<Func<T, bool>> predicate) =>
        _context.Set<T>()
            .AsQueryable()
            .Where(predicate)
            .ToList();

    public virtual T GetById(int id) =>
        _context.Find<T>(id);

    public virtual void Delete(T entity) =>
        _context.Remove(entity);
}
