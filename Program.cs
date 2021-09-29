using System;

namespace deckofcards
{
    class Program
    {
        static void Main(string[] args)
        {   
            Deck start = new Deck();
            start.Shuffle();
            // start.PrintDeck();
            Player one = new Player("Todd");
            one.Draw(start);
            one.Draw(start);
            one.Draw(start);
            one.Draw(start);
            one.Draw(start);
            one.ShowHand();
            one.Discard(1);
            Console.WriteLine("Discarded!");
            one.ShowHand();
        }
    }
}
