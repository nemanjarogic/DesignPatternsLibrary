using RestaurantManagement.Common;

namespace RestaurantManagement.Vegetarian;

/// <summary>
/// Concrete products are different implementations of the product interface <see cref="IMeal"/>.
/// </summary>
public class GreenSalad : IMeal
{
    public void ShowDescription() =>
        Console.WriteLine("Green salad - with lettuce, cucumber and green olives");
}
