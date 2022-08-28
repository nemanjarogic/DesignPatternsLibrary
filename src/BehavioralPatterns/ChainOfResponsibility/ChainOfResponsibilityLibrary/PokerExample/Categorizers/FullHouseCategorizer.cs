using ChainOfResponsibilityLibrary.PokerExample.Categorizers.Common;
using ChainOfResponsibilityLibrary.PokerExample.Models;
using ChainOfResponsibilityLibrary.PokerExample.Models.Enums;

namespace ChainOfResponsibilityLibrary.PokerExample.Categorizers;

public class FullHouseCategorizer : HandCategorizer
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

        if (seen.Count == 2)
        {
            if (seen.ContainsValue(3) && seen.ContainsValue(2))
            {
                return HandRanking.FullHouse;
            }
        }

        return CheckNextCategorizer(hand);
    }
}
