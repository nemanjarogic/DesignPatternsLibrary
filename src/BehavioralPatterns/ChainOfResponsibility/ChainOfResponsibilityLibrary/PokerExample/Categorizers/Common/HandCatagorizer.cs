using System.Collections.Generic;
using System.Linq;
using ChainOfResponsibilityLibrary.PokerExample.Models;
using ChainOfResponsibilityLibrary.PokerExample.Models.Enums;

namespace ChainOfResponsibilityLibrary.PokerExample.Categorizers.Common
{
    public abstract class HandCatagorizer
    {
        protected HandCatagorizer Next { get; private set; }

        public HandCatagorizer RegisterNext(HandCatagorizer next)
        {
            Next = next;
            return Next;
        }

        public abstract HandRanking Catagorize(Hand hand);

        protected static bool HasNOfKind(int n, Hand hand)
        {
            Dictionary<Value, int> seen = new Dictionary<Value, int>();

            foreach (Card card in hand.Cards)
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

            foreach (int count in seen.Values)
            {
                if (count == n)
                {
                    return true;
                }
            }

            return false;
        }

        protected static bool HasStraight(Hand hand)
        {
            List<Value> values = hand.Cards.Select(card => card.Value).ToList();
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
            List<Suit> suits = hand.Cards.Select(card => card.Suit).ToList();
            suits.Sort();

            Suit expectedSuit = suits.First();

            return suits.All(suit => suit == expectedSuit);
        }
    }
}
