using ChainOfResponsibilityLibrary.PokerExample.Categorizers.Common;
using ChainOfResponsibilityLibrary.PokerExample.Models;
using ChainOfResponsibilityLibrary.PokerExample.Models.Enums;

namespace ChainOfResponsibilityLibrary.PokerExample.Categorizers;

public class ThreeOfAKindCategorizer : HandCategorizer
{
    public override HandRanking Categorize(Hand hand)
    {
        if (HasNOfKind(3, hand))
        {
            return HandRanking.ThreeOfAKind;
        }

        return CheckNextCategorizer(hand);
    }
}
