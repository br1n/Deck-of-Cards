using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Player newPlayer = new Player("joe");
            Deck newDeck = new Deck();

            newDeck.ShowDeck();
            newDeck.Shuffle();
            newDeck.ShowDeck();
        }
    }
}
