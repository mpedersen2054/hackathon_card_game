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
            Deck deck = new Deck();
            deck.Shuffle();

            for (int i = 0; i < 26; i++)
            {
                player.Draw(deck);
                dealer.Draw(deck);
            }

            while (player.hand.Count > 1 || dealer.hand.Count > 1)
            {
                PlayCard();
            }
        }

        
    }
}
