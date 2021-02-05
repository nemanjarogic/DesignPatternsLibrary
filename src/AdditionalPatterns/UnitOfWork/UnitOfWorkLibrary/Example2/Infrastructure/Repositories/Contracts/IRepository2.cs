using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnitOfWorkLibrary.Domain;

namespace UnitOfWorkLibrary.Example2.Infrastructure.Repositories.Contracts
{
    public interface IRepository2<T>
        where T : Entity
    {
        IUnitOfWork2 UnitOfWork { get; }

        T Add(T entity);

        IEnumerable<T> GetAll();

        IEnumerable<T> Get(Expression<Func<T, bool>> predicate);

        T GetById(int id);

        void Delete(T entity);
    }
}
