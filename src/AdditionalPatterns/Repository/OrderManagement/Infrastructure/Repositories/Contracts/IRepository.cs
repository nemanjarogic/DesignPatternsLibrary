using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using OrderManagement.Domain;

namespace OrderManagement.Infrastructure.Repositories.Contracts
{
    public interface IRepository<T>
        where T : Entity
    {
        T Add(T entity);

        IEnumerable<T> GetAll();

        IEnumerable<T> Get(Expression<Func<T, bool>> predicate);

        T GetById(int id);

        void Delete(T entity);
    }
}
