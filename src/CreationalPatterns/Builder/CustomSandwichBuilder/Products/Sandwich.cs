using CustomSandwichBuilder.Products.Enums;
using System;
using System.Collections.Generic;

namespace CustomSandwichBuilder.Products
{
    /// <summary>
    /// Products are resulting objects. 
    /// Products constructed by different builders don’t have to belong to the same class hierarchy or interface.
    /// </summary>
    public class Sandwich
    {
        public Sandwich(string name)
        {
            Name = name;
        }

        public string Name { get; init; }

        public BreadType BreadType { get; set; }

        public CheeseType CheeseType { get; set; }

        public MeatType MeatType { get; set; }

        public bool IsToasted { get; set; }

        public bool HasMustard { get; set; }

        public bool HasMayonnaise { get; set; }

        public bool HasKetchup { get; set; }

        public List<string> Vegetables { get; set; }

        public void Display()
        {
            Console.WriteLine();
            Console.WriteLine(Name);
            Console.WriteLine("----------------");

            Console.WriteLine($"Sandwich on {BreadType} bread");

            if (IsToasted)
                Console.WriteLine("Toasted");

            if (HasMayonnaise)
                Console.WriteLine("With Mayonnaise");

            if (HasMustard)
                Console.WriteLine("With Mustard");

            if (HasKetchup)
                Console.WriteLine("With Ketchup");

            Console.WriteLine($"Meat: {MeatType}", MeatType);
            Console.WriteLine($"Cheese: {CheeseType}", CheeseType);

            Console.WriteLine($"Veggies:");
            foreach (var vegetable in Vegetables)
                Console.WriteLine($"   {vegetable}");
        }
    }
}
