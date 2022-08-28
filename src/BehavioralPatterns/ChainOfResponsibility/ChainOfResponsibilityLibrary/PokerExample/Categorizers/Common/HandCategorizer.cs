using ChainOfResponsibilityLibrary.PokerExample.Models;
using ChainOfResponsibilityLibrary.PokerExample.Models.Enums;

namespace ChainOfResponsibilityLibrary.PokerExample.Categorizers.Common;

public abstract class HandCategorizer
{
    protected HandCategorizer? Next { get; private set; }

    public HandCategorizer RegisterNext(HandCategorizer next)
    {
        Next = next;
        return Next;
    }

    public abstract HandRanking Categorize(Hand hand);

    protected HandRanking CheckNextCategorizer(Hand hand) => Next?.Categorize(hand) ?? HandRanking.HighCard;

    protected static bool HasNOfKind(int n, Hand hand)
    {
        var seen = new Dictionary<Value, int>();

        foreach (var card in hand.Cards)
        {
            if (seen.ContainsKey(card.Value))
            {
                seen[card.Value]++;
            }
            else
            {
                seen[card.Value] = 1;
            }
        }

        return seen.Values.Any(count => count == n);
    }

    protected static bool HasStraight(Hand hand)
    {
        var values = hand.Cards.Select(card => card.Value).ToList();
        values.Sort();

        var expectedValue = (int)values.First();

        foreach (Value value in values)
        {
            if ((int)value != expectedValue)
            {
                return false;
            }

            expectedValue++;
        }

        return true;
    }

    protected static bool HasFlush(Hand hand)
    {
        var suits = hand.Cards.Select(card => card.Suit).ToList();
        suits.Sort();

        var expectedSuit = suits.First();
        return suits.All(suit => suit == expectedSuit);
    }
}
