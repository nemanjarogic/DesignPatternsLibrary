using System;
using System.Collections.Generic;
using System.Linq;
using ProductSpecification.Domain;
using ProductSpecification.Specifications.Common;

namespace ProductSpecification.Infrastructure
{
    public class ProductRepository
    {
        private readonly List<Product> _products;

        public ProductRepository()
        {
            _products = new List<Product>
            {
                new Product("Designing Data-Intensive Applications", ProductCategory.Books, 44.50m, 4.7, new DateTime(2017, 4, 18)),
                new Product("Kindle Paperwhite", ProductCategory.Electronics, 84.99m, 4.6, new DateTime(2018, 1, 1)),
                new Product("USB Hub", ProductCategory.Electronics, 8.99m, 4.7, DateTime.Today.AddDays(-2)),
                new Product("Bed Sheet Set", ProductCategory.HomeAndKitchen, 35.99m, 4.2, new DateTime(2018, 8, 18)),
                new Product("UNO Card Game", ProductCategory.ToysAndGames, 9.99m, 4.9, new DateTime(2014, 4, 14)),
            };
        }

        public IReadOnlyList<Product> Find(Specification<Product> specification, int page = 0, int pageSize = 100)
        {
            return _products.AsQueryable()
                .Where(specification.ToExpression())
                .Skip(page * pageSize)
                .Take(pageSize)
                .ToList();
        }
    }
}
