using System;

namespace ProductSpecification.Domain
{
    public class Product : Entity
    {
        public Product(
            string title,
            ProductCategory category,
            decimal price,
            double rating,
            DateTime launchDate)
            : base()
        {
            Title = title;
            Category = category;
            Price = price;
            Rating = rating;
            LaunchDate = launchDate;
        }

        public string Title { get; set; }

        public ProductCategory Category { get; set; }

        public decimal Price { get; set; }

        public double Rating { get; set; }

        public DateTime LaunchDate { get; set; }

        public override string ToString()
        {
            return $"{Title} - Rating: {Rating} - Price: {Price:C} - Launched on: {LaunchDate.ToShortDateString()}";
        }
    }
}
