using ChainOfResponsibilityLibrary.PokerExample.Categorizers.Common;
using ChainOfResponsibilityLibrary.PokerExample.Models;
using ChainOfResponsibilityLibrary.PokerExample.Models.Enums;

namespace ChainOfResponsibilityLibrary.PokerExample.Categorizers;

public class StraightFlushCategorizer : HandCategorizer
{
    public override HandRanking Categorize(Hand hand)
    {
        if (HasFlush(hand) && HasStraight(hand))
        {
            return HandRanking.StraightFlush;
        }

        return CheckNextCategorizer(hand);
    }
}
