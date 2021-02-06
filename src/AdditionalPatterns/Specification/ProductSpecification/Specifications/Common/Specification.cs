using System;
using System.Linq.Expressions;

namespace ProductSpecification.Specifications.Common
{
    /// <summary>
    /// Specification pattern is a pattern that allows us to encapsulate some piece of domain knowledge
    /// into a single unit - specification, and reuse it in different parts of the code base.
    /// There are 3 main use cases for the specification pattern:
    /// 1) Looking up data in the database - finding records that match arbitrary specification.
    /// 2) Validating objects in the memory - checking whether object we retrieved or created fits arbitrary specification.
    /// 3) Creating a new instance that matches the criteria.
    /// For more details see: https://enterprisecraftsmanship.com/posts/specification-pattern-c-implementation/
    /// </summary>
    /// <typeparam name="T">Entity type.</typeparam>
    public abstract class Specification<T>
    {
        public abstract Expression<Func<T, bool>> ToExpression();

        public bool IsSatisfiedBy(T entity)
        {
            Func<T, bool> predicate = ToExpression().Compile();
            return predicate(entity);
        }

        public Specification<T> And(Specification<T> specification)
        {
            return new AndSpecification<T>(this, specification);
        }

        public Specification<T> Or(Specification<T> specification)
        {
            return new OrSpecification<T>(this, specification);
        }
    }
}
