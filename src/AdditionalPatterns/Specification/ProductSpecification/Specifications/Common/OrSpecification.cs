using System;
using System.Linq.Expressions;

namespace ProductSpecification.Specifications.Common
{
    public class OrSpecification<T> : Specification<T>
    {
        private readonly Specification<T> _left;
        private readonly Specification<T> _right;

        public OrSpecification(Specification<T> left, Specification<T> right)
        {
            _right = right;
            _left = left;
        }

        public override Expression<Func<T, bool>> ToExpression()
        {
            Expression<Func<T, bool>> leftExpression = _left.ToExpression();
            Expression<Func<T, bool>> rightExpression = _right.ToExpression();

            var paramExpression = Expression.Parameter(typeof(T));
            var expressionBody = Expression.OrElse(leftExpression.Body, rightExpression.Body);
            expressionBody = (BinaryExpression)new ParameterReplacer(paramExpression).Visit(expressionBody);

            var finalExpression = Expression.Lambda<Func<T, bool>>(expressionBody, paramExpression);

            return finalExpression;
        }
    }
}
