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

            Game game = new Game(matt, dealer);
            game.Start(); // splits the deck, gives player & dealer each 26 cards
        }
    }
}
