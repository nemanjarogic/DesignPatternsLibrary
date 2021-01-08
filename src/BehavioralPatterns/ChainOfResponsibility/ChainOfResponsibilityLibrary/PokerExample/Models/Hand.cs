using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ChainOfResponsibilityLibrary.PokerExample.Models.Enums;

namespace ChainOfResponsibilityLibrary.PokerExample.Models
{
    public class Hand
    {
        private readonly List<Card> _cards = new List<Card>();
        private HandRanking _rank = HandRanking.Unknown;

        public Card HighCard
        {
            get
            {
                if (_cards.Count == 0)
                {
                    throw new InvalidOperationException();
                }

                var orderedCards = _cards.ToList().OrderByDescending(card => card.Value);
                return orderedCards.First();
            }
        }

        public IEnumerable<Card> Cards
        {
            get
            {
                return _cards;
            }
        }

        public HandRanking Rank
        {
            get
            {
                return _rank;
            }
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            foreach (Card card in _cards)
            {
                builder.AppendFormat($"{card} ");
            }

            return builder.ToString();
        }

        public void Add(Card card)
        {
            if (_cards.Count == 5)
            {
                throw new InvalidOperationException("Cannot add more than 5 cards to a hand.");
            }

            _cards.Add(card);

            if (_cards.Count == 5)
            {
                _rank = HandCategorizerChain.GetRank(this);
            }
        }
    }
}
