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

        public object Discard(int desiredIdx)
        {
            try {
                Card card = hand[desiredIdx];
                hand.RemoveAt(desiredIdx);
                return card;
            } catch { return null; }
        }
        public void getHandString()
        {
            CardImages handStr = new CardImages(hand);
            System.Console.WriteLine(handStr.handString);
        }
    }
}
