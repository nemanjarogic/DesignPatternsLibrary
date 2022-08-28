using ChainOfResponsibilityLibrary.PokerExample.Categorizers.Common;
using ChainOfResponsibilityLibrary.PokerExample.Models;
using ChainOfResponsibilityLibrary.PokerExample.Models.Enums;

namespace ChainOfResponsibilityLibrary.PokerExample.Categorizers;

public class FlushCategorizer : HandCategorizer
{
    public override HandRanking Categorize(Hand hand)
    {
        if (HasFlush(hand))
        {
            return HandRanking.Flush;
        }

        return CheckNextCategorizer(hand);
    }
}
