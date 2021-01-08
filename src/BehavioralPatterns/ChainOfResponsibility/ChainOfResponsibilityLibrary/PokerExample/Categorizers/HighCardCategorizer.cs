using ChainOfResponsibilityLibrary.PokerExample.Categorizers.Common;
using ChainOfResponsibilityLibrary.PokerExample.Models;
using ChainOfResponsibilityLibrary.PokerExample.Models.Enums;

namespace ChainOfResponsibilityLibrary.PokerExample.Categorizers
{
    public class HighCardCategorizer : HandCatagorizer
    {
        public override HandRanking Catagorize(Hand hand)
        {
            return HandRanking.HighCard;
        }
    }
}
