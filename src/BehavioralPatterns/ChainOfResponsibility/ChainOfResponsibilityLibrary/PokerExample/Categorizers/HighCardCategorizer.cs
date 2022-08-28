using ChainOfResponsibilityLibrary.PokerExample.Categorizers.Common;
using ChainOfResponsibilityLibrary.PokerExample.Models;
using ChainOfResponsibilityLibrary.PokerExample.Models.Enums;

namespace ChainOfResponsibilityLibrary.PokerExample.Categorizers;

public class HighCardCategorizer : HandCategorizer
{
    public override HandRanking Categorize(Hand hand) => HandRanking.HighCard;
}
