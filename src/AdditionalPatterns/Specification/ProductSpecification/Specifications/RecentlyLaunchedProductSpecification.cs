using System;
using System.Linq.Expressions;
using ProductSpecification.Domain;
using ProductSpecification.Specifications.Common;

namespace ProductSpecification.Specifications
{
    public class RecentlyLaunchedProductSpecification : Specification<Product>
    {
        public override Expression<Func<Product, bool>> ToExpression()
        {
            // Products are considered as recently launched if they are launched in the last 7 days
            return product => DateTime.Today.AddDays(-7) <= product.LaunchDate;
        }
    }
}
