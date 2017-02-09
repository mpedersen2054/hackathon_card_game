using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Player matt = new Player("Matt");
            Player dealer = new Player("Dealer");

            Deck deck = new Deck();
            deck.Shuffle();

            for (int i = 0; i < 26; i++)
            {
                matt.Draw(deck);
                dealer.Draw(deck);
            }

            for (int i = 0; i < dealer.hand.Count; i++)
            {
                System.Console.WriteLine("matt: {0}", matt.hand[i].val);
                System.Console.WriteLine("Dealer: {0}", dealer.hand[i].val);
            }
            System.Console.WriteLine(deck.count);
        }
    }
}
