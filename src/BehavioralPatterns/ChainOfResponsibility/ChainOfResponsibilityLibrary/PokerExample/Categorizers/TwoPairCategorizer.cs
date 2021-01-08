using System.Collections.Generic;
using ChainOfResponsibilityLibrary.PokerExample.Categorizers.Common;
using ChainOfResponsibilityLibrary.PokerExample.Models;
using ChainOfResponsibilityLibrary.PokerExample.Models.Enums;

namespace ChainOfResponsibilityLibrary.PokerExample.Categorizers
{
    public class TwoPairCategorizer : HandCatagorizer
    {
        public override HandRanking Catagorize(Hand hand)
        {
            var seen = new Dictionary<Value, int>();

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

            if (seen.Count == 3)
            {
                int oneSeen = 0;
                int twoSeen = 0;

                foreach (int cardValueNumberOfRepetitions in seen.Values)
                {
                    switch (cardValueNumberOfRepetitions)
                    {
                        case 1:
                            oneSeen++;
                            break;
                        case 2:
                            twoSeen++;
                            break;
                        default:
                            break;
                    }
                }

                if (oneSeen == 1 && twoSeen == 2)
                {
                    return HandRanking.TwoPair;
                }
            }

            return Next.Catagorize(hand);
        }
    }
}
