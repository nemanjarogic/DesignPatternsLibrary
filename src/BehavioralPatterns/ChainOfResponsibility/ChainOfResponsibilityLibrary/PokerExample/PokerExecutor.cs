using BuildingBlocks;
using ChainOfResponsibilityLibrary.PokerExample.Models;

namespace ChainOfResponsibilityLibrary.PokerExample;

public static class PokerExecutor
{
    public static void Execute()
    {
        ConsoleExtension.WriteSeparator("Poker example");

        var deck = InitializeDeck();
        var handsOfPlayers = PlacePlayersAtTheTable();
        DealCards(deck, handsOfPlayers);
        ShowFinalScores(handsOfPlayers);
    }

    private static Deck InitializeDeck()
    {
        var deck = new Deck();
        deck.Shuffle();

        return deck;
    }

    // Each player that wants to play poker will have a hand.
    private static Hand[] PlacePlayersAtTheTable()
    {
        const int numberOfPlayers = 8;
        var handsOfPlayers = new Hand[numberOfPlayers];

        for (var index = 0; index < handsOfPlayers.Length; index++)
        {
            handsOfPlayers[index] = new Hand();
        }

        return handsOfPlayers;
    }

    private static void DealCards(Deck deck, Hand[] handsOfPlayers)
    {
        const int numberOfCardsInHand = 5;

        for (var dealingRound = 0; dealingRound < numberOfCardsInHand; dealingRound++)
        {
            foreach (var hand in handsOfPlayers)
            {
                hand.Add(deck.Deal());
            }
        }
    }

    private static void ShowFinalScores(Hand[] handsOfPlayers)
    {
        for (var i = 0; i < handsOfPlayers.Length; i++)
        {
            var hand = handsOfPlayers[i];
            Console.WriteLine($"Player #{i + 1}: {hand.Rank} ({hand})");
        }
    }
}
