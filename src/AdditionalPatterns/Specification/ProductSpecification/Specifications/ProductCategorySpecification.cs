using System;
using System.Linq.Expressions;
using ProductSpecification.Domain;
using ProductSpecification.Specifications.Common;

namespace ProductSpecification.Specifications
{
    public class ProductCategorySpecification : Specification<Product>
    {
        private readonly ProductCategory _category;

        public ProductCategorySpecification(ProductCategory category)
        {
            _category = category;
        }

        public override Expression<Func<Product, bool>> ToExpression()
        {
            return product => product.Category == _category;
        }
    }
}
