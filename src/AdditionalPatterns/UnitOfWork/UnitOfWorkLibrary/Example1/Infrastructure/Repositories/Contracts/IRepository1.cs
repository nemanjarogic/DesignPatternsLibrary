using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnitOfWorkLibrary.Domain;

namespace UnitOfWorkLibrary.Example1.Infrastructure.Repositories.Contracts
{
    public interface IRepository1<T>
        where T : Entity
    {
        T Add(T entity);

        IEnumerable<T> GetAll();

        IEnumerable<T> Get(Expression<Func<T, bool>> predicate);

        T GetById(int id);

        void Delete(T entity);
    }
}
