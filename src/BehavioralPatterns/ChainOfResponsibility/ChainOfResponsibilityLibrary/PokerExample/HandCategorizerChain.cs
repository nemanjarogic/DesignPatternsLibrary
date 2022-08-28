using ChainOfResponsibilityLibrary.PokerExample.Categorizers;
using ChainOfResponsibilityLibrary.PokerExample.Categorizers.Common;
using ChainOfResponsibilityLibrary.PokerExample.Models;
using ChainOfResponsibilityLibrary.PokerExample.Models.Enums;

namespace ChainOfResponsibilityLibrary.PokerExample;

public class HandCategorizerChain
{
    private static readonly HandCategorizerChain Instance = new();

    private HandCategorizerChain()
    {
        Head = new RoyalFlushCategorizer();
        Head.RegisterNext(new StraightFlushCategorizer())
            .RegisterNext(new FourOfAKindCategorizer())
            .RegisterNext(new FullHouseCategorizer())
            .RegisterNext(new FlushCategorizer())
            .RegisterNext(new StraightCategorizer())
            .RegisterNext(new ThreeOfAKindCategorizer())
            .RegisterNext(new TwoPairCategorizer())
            .RegisterNext(new PairCategorizer())
            .RegisterNext(new HighCardCategorizer());
    }

    private HandCategorizer Head { get; }

    public static HandRanking GetRank(Hand hand) => Instance.Head.Categorize(hand);
}
