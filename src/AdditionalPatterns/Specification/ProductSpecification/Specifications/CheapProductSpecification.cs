using System;
using System.Linq.Expressions;
using ProductSpecification.Domain;
using ProductSpecification.Specifications.Common;

namespace ProductSpecification.Specifications
{
    /// <summary>
    /// Domain knowledge is contained within concrete specifications making it much easier to reuse.
    /// </summary>
    public class CheapProductSpecification : Specification<Product>
    {
        private const decimal PriceThreshold = 10;

        public override Expression<Func<Product, bool>> ToExpression()
        {
            return product => product.Price < PriceThreshold;
        }
    }
}
