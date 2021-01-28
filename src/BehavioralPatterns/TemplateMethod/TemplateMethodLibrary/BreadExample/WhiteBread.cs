using System;

namespace TemplateMethodLibrary.BreadExample
{
    public class WhiteBread : Bread
    {
        public override void MixIngredients()
        {
            Console.WriteLine("Gathering ingredients for white bread.");
        }

        public override void Bake()
        {
            Console.WriteLine("Baking the white bread for 15 minutes.");
        }
    }
}
