using BuildingBlocks;
using ProductSpecification.Infrastructure;
using ProductSpecification.Specifications;

namespace ProductSpecification;

public class Executor : PatternExecutor
{
    public override string Name => "Specification - Architectural Pattern";

    public override void Execute()
    {
        var productRepository = new ProductRepository();

        var cheap = new CheapProductSpecification();
        var topRated = new TopRatedProductSpecification();
        var cheapAndTopRated = cheap.And(topRated);

        Console.WriteLine("Searching for cheap and top rated products...");
        var products = productRepository.Find(cheapAndTopRated);

        var recentlyLaunched = new RecentlyLaunchedProductSpecification();
        var ordinalNumber = 1;

        foreach (var product in products)
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine($"{ordinalNumber}) {product}");

            // Specifications could be used in different parts of the application.
            if (recentlyLaunched.IsSatisfiedBy(product))
            {
                Console.WriteLine($"Sending promotional email about recently launched product '{product.Title}'...");
            }

            ordinalNumber++;
        }
    }
}
