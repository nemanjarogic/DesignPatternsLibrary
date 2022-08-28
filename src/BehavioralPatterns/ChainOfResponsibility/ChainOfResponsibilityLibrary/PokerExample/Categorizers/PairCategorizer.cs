using ChainOfResponsibilityLibrary.PokerExample.Categorizers.Common;
using ChainOfResponsibilityLibrary.PokerExample.Models;
using ChainOfResponsibilityLibrary.PokerExample.Models.Enums;

namespace ChainOfResponsibilityLibrary.PokerExample.Categorizers;

public class PairCategorizer : HandCategorizer
{
    public override HandRanking Categorize(Hand hand)
    {
        if (HasNOfKind(2, hand))
        {
            return HandRanking.Pair;
        }

        return CheckNextCategorizer(hand);
    }
}
