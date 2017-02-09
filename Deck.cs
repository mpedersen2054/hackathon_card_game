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
            this.ResetDeck();
        }
        public void GetDeckLen()
        {
            System.Console.WriteLine(this.cards.Count);
        }

        public void Shuffle()
        {
            // loop over each card, remove it, insert it into
            // a random 0-51 index of this.cards
            for (int i = 0; i < this.cards.Count; i++)
            {
                // select card and remove it from list
                Card currCard = this.cards[i];
                this.cards.RemoveAt(i);
                // insert currCard[rand 0-51]
                int newIdx = rand.Next(0, this.cards.Count);
                this.cards.Insert(newIdx, currCard);
            }

            // // print out each card
            // foreach (Card card in this.cards)
            // {
            //     System.Console.WriteLine(card.fullName);
            // }
        }

        public Card Deal()
        {
            // select the top card, remove it and return it
            int topIdx = this.cards.Count - 1;
            Card topCard = this.cards[topIdx];
            this.cards.RemoveAt(topIdx);
            return topCard;
        }

        public void ResetDeck()
        {
            this.cards = new List<Card>();
            // iterate over each suit
            foreach (string suit in suits)
            {
                // another loop for each card per suit
                for (int i = 1; i < 14; i++)
                {
                    this.cards.Add(new Card(suit, i));
                }
            }

            // print out each card in new deck & deck.Count
            // foreach (Card card in this.cards)
            // {
            //     System.Console.WriteLine(card.imageString.image);
            // }
        }
    }
}
