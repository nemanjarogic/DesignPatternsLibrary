using System;
using BuildingBlocks;
using ChainOfResponsibilityLibrary.PokerExample.Models;

namespace ChainOfResponsibilityLibrary.PokerExample
{
    public static class PokerExecutor
    {
        public static void Execute()
        {
            ConsoleExtension.WriteSeparator("Poker example");

            Deck deck = new Deck();
            deck.Shuffle();

            var hands = new Hand[10];
            for (var index = 0; index < hands.Length; index++)
            {
                hands[index] = new Hand();
            }

            var numberOfCardsInHand = 5;
            for (int dealingRound = 0; dealingRound < numberOfCardsInHand; dealingRound++)
            {
                foreach (Hand hand in hands)
                {
                    hand.Add(deck.Deal());
                }
            }

            foreach (Hand hand in hands)
            {
                Console.WriteLine($"{hand.Rank} ({hand})");
            }
        }
    }
}
