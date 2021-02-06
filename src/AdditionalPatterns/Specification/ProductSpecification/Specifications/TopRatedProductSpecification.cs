using System;
using System.Linq.Expressions;
using ProductSpecification.Domain;
using ProductSpecification.Specifications.Common;

namespace ProductSpecification.Specifications
{
    public class TopRatedProductSpecification : Specification<Product>
    {
        private const double TopRatingThreshold = 4.5;

        public override Expression<Func<Product, bool>> ToExpression()
        {
            return product => product.Rating >= TopRatingThreshold;
        }
    }
}
