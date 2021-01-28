using System;

namespace TemplateMethodLibrary.BreadExample
{
    public class WholeWheatBread : Bread
    {
        public override void MixIngredients()
        {
            Console.WriteLine("Gathering ingredients for whole wheat bread.");
        }

        public override void Bake()
        {
            Console.WriteLine("Baking the whole wheat bread for 20 minutes.");
        }
    }
}
