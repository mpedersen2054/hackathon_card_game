using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Game
    {
        public Player player;
        public Player dealer;
        private int playerHardLen;
        private int dealerHandLen;
        public Game(Player playr, Player dealr)
        {
            player = playr;
            dealer = dealr;

            playerHardLen = player.hand.Count;
            dealerHandLen = dealer.hand.Count;
        }

        public void Start()
        {
            System.Console.WriteLine("STARTING GAME");
        }
    }
}
