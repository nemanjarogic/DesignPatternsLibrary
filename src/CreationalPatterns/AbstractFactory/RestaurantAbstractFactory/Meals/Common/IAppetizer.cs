namespace RestaurantAbstractFactory.Meals.Common
{
    /// <summary>
    /// Abstract Products declare interfaces for a set of distinct
    /// but related products which make up a product family.
    /// Each abstract product must be implemented in all given variants, which for this project are
    /// <see cref="FastFood.FastFoodAppetizer"/> and <seealso cref="Vegetarian.VegetarianAppetizer"/>
    /// </summary>
    public interface IAppetizer : IMeal
    {
        bool IsBroth();
    }
}
