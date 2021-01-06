namespace DecoratorLibrary.PancakeExample.Components.Common
{
    public abstract class Pancake
    {
        public string Description { get; set; }

        public abstract double CalculatePrice();

        public virtual string GetDescriptionAndAddIns()
        {
            return Description;
        }
    }
}
