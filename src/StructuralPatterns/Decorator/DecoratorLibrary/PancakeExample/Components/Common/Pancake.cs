namespace DecoratorLibrary.PancakeExample.Components.Common;

public abstract class Pancake
{
    public string Description { get; set; } = string.Empty;

    public abstract double CalculatePrice();

    public virtual string GetDescriptionAndAddIns() => Description;
}
