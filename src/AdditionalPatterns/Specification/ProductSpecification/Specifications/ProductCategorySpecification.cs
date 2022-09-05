using ProductSpecification.Domain;
using ProductSpecification.Specifications.Common;
using System.Linq.Expressions;

namespace ProductSpecification.Specifications;

public class ProductCategorySpecification : Specification<Product>
{
    private readonly ProductCategory _category;

    public ProductCategorySpecification(ProductCategory category)
    {
        _category = category;
    }

    public override Expression<Func<Product, bool>> ToExpression() =>
        product => product.Category == _category;
}
