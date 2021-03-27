using System;

namespace TemplateMethodLibrary.BreadExample
{
    public class WholeWheatBread : Bread
    {
        protected override void MixIngredients()
        {
            Console.WriteLine("Gathering ingredients for whole wheat bread.");
        }

        protected override void Bake()
        {
            Console.WriteLine("Baking the whole wheat bread for 20 minutes.");
        }
    }
}
