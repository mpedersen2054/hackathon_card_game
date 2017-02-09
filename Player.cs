using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Player
    {
        public string name;
        public List<Card> hand;
        public Player(string name = "No Name")
        {
            this.name = name;
            hand = new List<Card>();
        }
        public Card Draw(Deck deck)
        {
            Card newCard = deck.Deal();
            hand.Add(newCard);
            return newCard;
        }

        public Card Discard(int desiredIdx)
        {
            try {
                Card card = hand[desiredIdx];
                hand.RemoveAt(desiredIdx);
                return card;
            } catch { return null; }
        }

        public Card TakeTopCard()
        {
            int removeIdx = hand.Count - 1;
            Card topCard = hand[removeIdx];
            hand.RemoveAt(removeIdx);
            return topCard;
        }
        
        public void ShowHandString()
        {
            string handString = "";
            foreach (Card card in hand)
            {
                handString += card.val + ", ";
            }
            System.Console.WriteLine(handString);
        }
    }
}
