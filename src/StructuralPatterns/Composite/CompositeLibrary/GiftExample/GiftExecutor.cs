using System;
using BuildingBlocks;

namespace CompositeLibrary.GiftExample
{
    public static class GiftExecutor
    {
        public static void Execute()
        {
            ConsoleExtension.WriteSeparator("Gift example");

            var smartWatchGift = new SimpleGift("Smart watch", 200);
            var smartWatchPrice = smartWatchGift.CalculatePrice();
            Console.WriteLine($"Total price for smart watch gift: {smartWatchPrice:C}");

            Console.WriteLine();

            var familyGift = new CompositeGift("Family gift");
            var dadsGift = new SimpleGift("Fishing rod", 50);
            var momsGift = new SimpleGift("Necklace", 80);
            var childrenGift = new CompositeGift("Children gift");
            var soldierToy = new SimpleGift("Soldier toy", 40);
            var barbieToy = new SimpleGift("Barbie toy", 50);

            childrenGift.Add(soldierToy);
            childrenGift.Add(barbieToy);

            familyGift.Add(dadsGift);
            familyGift.Add(momsGift);
            familyGift.Add(childrenGift);

            var familyGiftPrice = familyGift.CalculatePrice();
            Console.WriteLine($"Total price for family gift: {familyGiftPrice:C}");
        }
    }
}
