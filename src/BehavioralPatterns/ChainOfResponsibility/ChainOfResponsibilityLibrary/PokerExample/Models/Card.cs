using System;
using ChainOfResponsibilityLibrary.PokerExample.Models.Enums;

namespace ChainOfResponsibilityLibrary.PokerExample.Models
{
    public class Card
    {
        public Card(Suit suit, Value value)
        {
            Suit = suit;
            Value = value;
        }

        public Suit Suit { get; private set; }

        public Value Value { get; private set; }

        public override string ToString()
        {
            return ValueToString() + SuitToString();
        }

        private string SuitToString()
        {
            return Suit switch
            {
                Suit.Club => "C",
                Suit.Heart => "H",
                Suit.Diamond => "D",
                Suit.Spade => "S",
                _ => throw new NotImplementedException(),
            };
        }

        private string ValueToString()
        {
            return Value switch
            {
                Value.Two => "2",
                Value.Three => "3",
                Value.Four => "4",
                Value.Five => "5",
                Value.Six => "6",
                Value.Seven => "7",
                Value.Eight => "8",
                Value.Nine => "9",
                Value.Ten => "10",
                Value.Jack => "J",
                Value.Queen => "Q",
                Value.King => "K",
                Value.Ace => "A",
                _ => throw new NotImplementedException(),
            };
        }
    }
}
