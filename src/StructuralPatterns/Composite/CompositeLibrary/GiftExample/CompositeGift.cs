using CompositeLibrary.GiftExample.Common;

namespace CompositeLibrary.GiftExample;

public class CompositeGift : Gift, IGiftOperations
{
    /// <summary>
    /// This collection can store simple as well as composite gifts.
    /// </summary>
    private readonly List<Gift> _gifts;

    public CompositeGift(string description)
        : base(description, 0)
    {
        _gifts = new List<Gift>();
    }

    public void Add(Gift gift) =>
        _gifts.Add(gift);

    public void Remove(Gift gift) =>
        // Consider using HashSet or Dictionary if you need remove an item from a collection.
        _gifts.Remove(gift);

    public override decimal CalculatePrice()
    {
        Console.WriteLine($"'{_description}' contains the following products with prices:");
        _price = _gifts.Sum(gift => gift.CalculatePrice());

        return _price;
    }
}
