using ChainOfResponsibilityLibrary.PokerExample.Categorizers.Common;
using ChainOfResponsibilityLibrary.PokerExample.Models;
using ChainOfResponsibilityLibrary.PokerExample.Models.Enums;

namespace ChainOfResponsibilityLibrary.PokerExample.Categorizers
{
    public class FourOfAKindCategorizer : HandCatagorizer
    {
        public override HandRanking Catagorize(Hand hand)
        {
            if (HasNOfKind(4, hand))
            {
                return HandRanking.FourOfAKind;
            }

            return Next.Catagorize(hand);
        }
    }
}
