﻿using System.Linq.Expressions;
using UnitOfWorkLibrary.Domain;
using UnitOfWorkLibrary.Example2.Infrastructure.Repositories.Contracts;

namespace UnitOfWorkLibrary.Example2.Infrastructure.Repositories;

/// <summary>
/// Repositories completely encapsulates all the minutiae of data access.
/// Typically, data access code is very repetitive, and it's concerned with low-level infrastructure details
/// like opening database connections, managing transactions and so on.
/// We don't want that sort of code duplicated throughout our business logic.
/// What we'd like to do is extract that so that the business logic is just focused on implementing
/// the special algorithms that are crucial to the business.
/// </summary>
/// <typeparam name="T">Entity type.</typeparam>
public abstract class Repository2<T> : IRepository2<T>
    where T : Entity
{
    protected OrderManagementContext2 _context;

    protected Repository2(OrderManagementContext2 context)
    {
        _context = context;
    }

    public IUnitOfWork2 UnitOfWork => _context;

    public virtual T Add(T entity) =>
        _context.Add(entity).Entity;

    public virtual IEnumerable<T> GetAll() =>
        _context.Set<T>().ToList();

    public virtual IEnumerable<T> Get(Expression<Func<T, bool>> predicate) =>
        _context.Set<T>()
            .AsQueryable()
            .Where(predicate)
            .ToList();

    public virtual T GetById(int id)
    {
        var entity = _context.Find<T>(id);
        return entity ?? throw new ArgumentException($"Entity with {id} doesn't exists");
    }

    public virtual void Delete(T entity) =>
        _context.Remove(entity);
}
