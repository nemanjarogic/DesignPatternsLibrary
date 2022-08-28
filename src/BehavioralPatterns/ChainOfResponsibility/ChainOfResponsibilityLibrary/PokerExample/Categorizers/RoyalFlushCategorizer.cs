using ChainOfResponsibilityLibrary.PokerExample.Categorizers.Common;
using ChainOfResponsibilityLibrary.PokerExample.Models;
using ChainOfResponsibilityLibrary.PokerExample.Models.Enums;

namespace ChainOfResponsibilityLibrary.PokerExample.Categorizers;

public class RoyalFlushCategorizer : HandCategorizer
{
    public override HandRanking Categorize(Hand hand)
    {
        if (HasFlush(hand) && HasStraight(hand) && hand.HighCard.Value == Value.Ace)
        {
            return HandRanking.RoyalFlush;
        }

        return CheckNextCategorizer(hand);
    }
}
