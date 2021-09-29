using System;
using System.Collections.Generic;

namespace deckofcards
{
    public class Player
    {
        private string name;
        public string Name
        {
            get{return name;}
        }
        private List<Card> hand;
        public List<Card> Hand
        {
            get{return hand;}
        }
        public Player(string namecustom)
        {
            name = namecustom;
            hand = new List<Card>();
        }

        public Card Draw(Deck deck)
        {
            Card drawnCard = deck.cards[0];
            hand.Add(drawnCard);
            deck.cards.RemoveAt(0);
            return drawnCard;
        }
        public void ShowHand()
        {   
            foreach(Card card in Hand)
            {
                card.Print();
            }
        }
        public Card Discard(int num)
        {
            if(num < hand.Count)
            {
                Card chosen = hand[num];
                Hand.RemoveAt(num);
                return chosen;

            }
            else
            {
                return null;
            }
        }
    }
}