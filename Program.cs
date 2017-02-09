using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.Shuffle();

            Player matt = new Player("Matt");
            Player dealer = new Player("Dealer");

            matt.Draw(deck);
            matt.Draw(deck);
            dealer.Draw(deck);
            dealer.Draw(deck);
            // deck.GetDeckLen();

            System.Console.WriteLine("HELLLO KENNEN");
            System.Console.WriteLine("HELLLO matt from kennon");
            System.Console.WriteLine("HELLLO Matt& Kennon from Jalal");

            for (int i = 0; i < matt.hand.Count; i++)
            {
                System.Console.WriteLine("Matt: {0}", matt.hand[i].fullName);
                System.Console.WriteLine("Dealer: {0}", dealer.hand[i].fullName);
            }

            // object mattcard = matt.Discard(1);
            // if (mattcard is Card)
            // {
            //     Card mattcard1 = (Card)mattcard;
            //     System.Console.WriteLine(mattcard1.fullName);
            // }
            // else
            // {
            //     System.Console.WriteLine("Card doesnt exist");
            // }
            // System.Console.WriteLine("Matt has {0} cards.", matt.hand.Count);
            
            
        }
    }
}
