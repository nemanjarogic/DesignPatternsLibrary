using ChainOfResponsibilityLibrary.PokerExample.Categorizers.Common;
using ChainOfResponsibilityLibrary.PokerExample.Models;
using ChainOfResponsibilityLibrary.PokerExample.Models.Enums;

namespace ChainOfResponsibilityLibrary.PokerExample.Categorizers;

public class TwoPairCategorizer : HandCategorizer
{
    public override HandRanking Categorize(Hand hand)
    {
        var seen = new Dictionary<Value, int>();

        foreach (var card in hand.Cards)
        {
            if (seen.ContainsKey(card.Value))
            {
                seen[card.Value]++;
            }
            else
            {
                seen[card.Value] = 1;
            }
        }

        if (seen.Count == 3)
        {
            var numberOfSingleCards = 0;
            var numberOfPairs = 0;

            foreach (var cardFrequency in seen.Values)
            {
                if (cardFrequency == 1)
                {
                    numberOfSingleCards++;
                }
                else if (cardFrequency == 2)
                {
                    numberOfPairs++;
                }
            }

            if (numberOfSingleCards == 1 && numberOfPairs == 2)
            {
                return HandRanking.TwoPair;
            }
        }

        return CheckNextCategorizer(hand);
    }
}
