using ChainOfResponsibilityLibrary.PokerExample.Categorizers.Common;
using ChainOfResponsibilityLibrary.PokerExample.Models;
using ChainOfResponsibilityLibrary.PokerExample.Models.Enums;

namespace ChainOfResponsibilityLibrary.PokerExample.Categorizers;

public class StraightCategorizer : HandCategorizer
{
    public override HandRanking Categorize(Hand hand)
    {
        if (HasStraight(hand))
        {
            return HandRanking.Straight;
        }

        return CheckNextCategorizer(hand);
    }
}
