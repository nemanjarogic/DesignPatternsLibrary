using System;

namespace TemplateMethodLibrary.BreadExample
{
    public class WhiteBread : Bread
    {
        protected override void MixIngredients()
        {
            Console.WriteLine("Gathering ingredients for white bread.");
        }

        protected override void Bake()
        {
            Console.WriteLine("Baking the white bread for 15 minutes.");
        }
    }
}
