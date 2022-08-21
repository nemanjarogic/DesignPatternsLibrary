using System.Globalization;
using System.Reflection;
using MealSimpleFactory.Meals;
using MealSimpleFactory.Meals.Common;

namespace MealSimpleFactory.Factories;

/// <summary>
/// A simple meal factory that creates various types of meals based on a key for Type lookup.
/// It doesn't implement any interface, it's just a simple factory.
/// </summary>
public class MealFactory
{
    private readonly Dictionary<string, Type> _meals = new();

    public MealFactory()
    {
        LoadAvailableMealTypes();
    }

    public IMeal CreateMeal(string mealName)
    {
        var type = GetTypeForCreation(mealName);
        if (type == null)
        {
            return new NullMeal();
        }

        return (Activator.CreateInstance(type) as IMeal)!;
    }

    private Type? GetTypeForCreation(string mealName) =>
        _meals.TryGetValue(mealName, out var type) ? type : null;

    /// <summary>
    /// Load available meal types.
    /// Using reflection to populate meals is just implementation detail.
    /// It can be achieved in various ways.
    /// </summary>
    private void LoadAvailableMealTypes()
    {
        Type[] assemblyTypes = Assembly.GetExecutingAssembly().GetTypes();

        foreach (Type type in assemblyTypes)
        {
            if (type.GetInterface(typeof(IMeal).ToString()) != null)
            {
                _meals.Add(type.Name, type);
            }
        }
    }
}
