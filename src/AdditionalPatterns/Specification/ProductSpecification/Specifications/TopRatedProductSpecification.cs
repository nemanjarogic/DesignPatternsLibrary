using ProductSpecification.Domain;
using ProductSpecification.Specifications.Common;
using System.Linq.Expressions;

namespace ProductSpecification.Specifications;

public class TopRatedProductSpecification : Specification<Product>
{
    private const double TopRatingThreshold = 4.5;

    public override Expression<Func<Product, bool>> ToExpression() =>
        product => product.Rating >= TopRatingThreshold;
}
