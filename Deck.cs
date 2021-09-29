using System;
using System.Collections.Generic;

namespace deckofcards
{
    public class Deck
    {
        public List<Card> cards;

        public Deck()
        {
            cards = new List<Card>();
            populateDeck();
        }
        private void populateDeck()
        {
            string[] suits = {"Spades", "Diamonds", "Hearts", "Clubs"};
            foreach (string suit in suits)
            {
                for(int i =1; i<14; i++)
                {
                    string stringVal;
                    if(i > 1 && i<11)
                    {
                        stringVal=i.ToString();
                    }
                    else if(i==1){
                        stringVal="Ace";
                    }
                    else if(i==11){
                        stringVal="Jack";
                    }
                    else if(i==12){
                        stringVal="Queen";
                    }
                    else
                    {
                        stringVal="King";
                    }
                    cards.Add(new Card(stringVal, suit, i));
                }
            }
        }
        public void Reset()
        {
            populateDeck();
            Shuffle();
        }

        public Card Draw()
        {
            Card drawnCard = cards[0];
            cards.RemoveAt(0);
            return drawnCard;
        }



        public void Shuffle()
        {
            Random rand = new Random();
            List<Card> newList = new List<Card>();

            while(cards.Count >0)
            {
                int randIndex = rand.Next(cards.Count);
                newList.Add(cards[randIndex]);
                cards.RemoveAt(randIndex);
            }
            cards = newList;
        }

        public void PrintDeck()
        {
            foreach(Card card in cards)
            {
                card.Print();
            }
        }
    }
}