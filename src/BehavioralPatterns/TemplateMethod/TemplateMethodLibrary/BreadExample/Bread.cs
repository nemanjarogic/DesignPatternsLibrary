using System;

namespace TemplateMethodLibrary.BreadExample
{
    public abstract class Bread
    {
        /// <summary>
        /// The template method.
        /// </summary>
        public void Make()
        {
            MixIngredients();
            Bake();
            Slice();
        }

        public abstract void MixIngredients();

        public abstract void Bake();

        public virtual void Slice()
        {
            Console.WriteLine($"Slicing the {GetType().Name}!");
        }
    }
}
