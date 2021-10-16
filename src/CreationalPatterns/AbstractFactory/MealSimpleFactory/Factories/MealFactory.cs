using System;
using System.Collections.Generic;
using System.Reflection;
using MealSimpleFactory.Meals;
using MealSimpleFactory.Meals.Common;

namespace MealSimpleFactory.Factories
{
    /// <summary>
    /// A simple meal factory that creates various types of meals based on a key for Type lookup.
    /// It doesn't implement any interface, it's just a simple factory.
    /// </summary>
    public class MealFactory
    {
        private Dictionary<string, Type> _meals;

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

            return Activator.CreateInstance(type) as IMeal;
        }

        private Type GetTypeForCreation(string mealName)
        {
            if (!_meals.TryGetValue(mealName, out Type type))
            {
                return null;
            }

            return type;
        }

        /// <summary>
        /// Load available meal types.
        /// Using reflection to populate meals is just implementation detail.
        /// It can be achieved in various ways.
        /// </summary>
        private void LoadAvailableMealTypes()
        {
            _meals = new Dictionary<string, Type>();

            Type[] assemblyTypes = Assembly.GetExecutingAssembly().GetTypes();

            foreach (Type type in assemblyTypes)
            {
                if (type.GetInterface(typeof(IMeal).ToString()) != null)
                {
                    _meals.Add(type.Name.ToLower(), type);
                }
            }
        }
    }
}
