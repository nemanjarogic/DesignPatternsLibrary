using System;
using System.Collections.Generic;
using System.Linq;
using ChainOfResponsibilityLibrary.PokerExample.Models.Enums;

namespace ChainOfResponsibilityLibrary.PokerExample.Models
{
    public class Deck
    {
        private Queue<Card> _cards;

        public Deck()
        {
            _cards = new Queue<Card>();

            var suitMin = (int)Suit.Diamond;
            var suitMax = (int)Suit.Spade;

            var valueMin = (int)Value.Two;
            var valueMax = (int)Value.Ace;

            for (int suit = suitMin; suit <= suitMax; suit++)
            {
                for (int value = valueMin; value <= valueMax; value++)
                {
                    _cards.Enqueue(new Card((Suit)suit, (Value)value));
                }
            }
        }

        public Card Deal()
        {
            return _cards.Dequeue();
        }

        public void Shuffle()
        {
            Shuffle(7);
        }

        public void Shuffle(int numberOfShufflesToRandomizeDeck)
        {
            for (int index = 0; index < numberOfShufflesToRandomizeDeck; index++)
            {
                Queue<Card> newDeck = new Queue<Card>(_cards.OrderBy(_ => Guid.NewGuid()));
                _cards = newDeck;
            }
        }
    }
}
