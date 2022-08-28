using ChainOfResponsibilityLibrary.PokerExample.Models.Enums;

namespace ChainOfResponsibilityLibrary.PokerExample.Models;

public class Deck
{
    private Queue<Card> _cards;

    public Deck()
    {
        _cards = new Queue<Card>();

        const int suitMin = (int)Suit.Diamond;
        const int suitMax = (int)Suit.Spade;
        const int valueMin = (int)Value.Two;
        const int valueMax = (int)Value.Ace;

        for (var suit = suitMin; suit <= suitMax; suit++)
        {
            for (var value = valueMin; value <= valueMax; value++)
            {
                _cards.Enqueue(new Card((Suit)suit, (Value)value));
            }
        }
    }

    public Card Deal() => _cards.Dequeue();

    public void Shuffle() => Shuffle(7);

    private void Shuffle(int numberOfShufflesToRandomizeDeck)
    {
        for (var index = 0; index < numberOfShufflesToRandomizeDeck; index++)
        {
            var newDeck = new Queue<Card>(_cards.OrderBy(_ => Guid.NewGuid()));
            _cards = newDeck;
        }
    }
}
