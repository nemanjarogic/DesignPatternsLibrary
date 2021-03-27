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

        protected abstract void MixIngredients();

        protected abstract void Bake();

        protected virtual void Slice()
        {
            Console.WriteLine($"Slicing the {GetType().Name}!");
        }
    }
}
