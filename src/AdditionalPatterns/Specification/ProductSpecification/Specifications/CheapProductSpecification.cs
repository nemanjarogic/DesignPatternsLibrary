using ProductSpecification.Domain;
using ProductSpecification.Specifications.Common;
using System.Linq.Expressions;

namespace ProductSpecification.Specifications;

/// <summary>
/// Domain knowledge is contained within concrete specifications making it much easier to reuse.
/// </summary>
public class CheapProductSpecification : Specification<Product>
{
    private const decimal PriceThreshold = 10;

    public override Expression<Func<Product, bool>> ToExpression() =>
        product => product.Price < PriceThreshold;
}
