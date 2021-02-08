using System;
using DesignPatternsLibrary.PatternExecutors;
using ProductSpecification.Infrastructure;
using ProductSpecification.Specifications;

namespace ProductSpecification
{
    public class Executor : PatternExecutor
    {
        public override string Name => "Specification - Architectural Pattern";

        public override void Execute()
        {
            var productRepository = new ProductRepository();

            var recentlyLaunched = new RecentlyLaunchedProductSpecification();

            var cheap = new CheapProductSpecification();
            var topRated = new TopRatedProductSpecification();
            var specification = cheap.And(topRated);

            Console.WriteLine("Searching for cheap and top rated products...");
            var products = productRepository.Find(specification);

            foreach (var product in products)
            {
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine(product);

                // Specifications could be used in different parts of the application
                if (recentlyLaunched.IsSatisfiedBy(product))
                {
                    Console.WriteLine($"Sending promotional email about recently launched product '{product.Title}'");
                }
            }
        }
    }
}
