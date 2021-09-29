using System;

namespace deckofcards
{
    public class Card
    {
        private string stringVal;
        public string StringVal
        {
            get{return stringVal;}
        }
        private string suit;
        public string Suit
        {
            get{return suit;}
        }
        private int  val;
        public int Val
        {
            get{return val;}
        }


        public Card(string newStringval, string newSuit, int newVal)
        {
            stringVal = newStringval;
            suit = newSuit;
            val = newVal;
        }

        public void Print()
        {
            Console.WriteLine($"The {stringVal} of {suit}");
        }
    }
}