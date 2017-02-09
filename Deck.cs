using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Deck
    {
        Random rand = new Random();
        string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades" };
        public List<Card> cards = new List<Card>();
        
        public Deck()
        {
            ResetDeck();
        }
        public void GetDeckLen()
        {
            System.Console.WriteLine(cards.Count);
        }

        public void Shuffle()
        {
            // loop over each card, remove it, insert it into
            // a random 0-51 index of cards
            for (int i = 0; i < cards.Count; i++)
            {
                // select card and remove it from list
                Card currCard = cards[i];
                cards.RemoveAt(i);
                // insert currCard[rand 0-51]
                int newIdx = rand.Next(0, cards.Count);
                cards.Insert(newIdx, currCard);
            }

            // // print out each card
            // foreach (Card card in cards)
            // {
            //     System.Console.WriteLine(card.fullName);
            // }
        }

        public Card Deal()
        {
            // select the top card, remove it and return it
            int topIdx = cards.Count - 1;
            Card topCard = cards[topIdx];
            cards.RemoveAt(topIdx);
            return topCard;
        }

        public void ResetDeck()
        {
            cards = new List<Card>();
            // iterate over each suit
            foreach (string suit in suits)
            {
                // another loop for each card per suit
                for (int i = 1; i < 14; i++)
                {
                    cards.Add(new Card(suit, i));
                }
            }

            // print out each card in new deck & deck.Count
            // foreach (Card card in cards)
            // {
            //     System.Console.WriteLine(card.imageString.image);
            // }
        }
    }
}
