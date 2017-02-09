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
                PlayCards();
            }

        }

        private void PlayCards()
        {
            Card playerTC = player.TakeTopCard();
            Card dealerTC = dealer.TakeTopCard();
            
            System.Console.WriteLine("Player card: {0}", playerTC.val);
            System.Console.WriteLine("Dealer card: {0}", dealerTC.val);
            System.Console.WriteLine("===================");

            // Player and Dealer tie
            if (playerTC.val ==  dealerTC.val)
                {
                    System.Console.WriteLine("Cards are Tied! Play0ff");
                    // method should be written for playoff

                }
            // Player Card is > Dealer Card
            if (playerTC.val >  dealerTC.val)
                {
                    System.Console.WriteLine("Player Wins!");
                }
            // Dealer Card is > Player Card
            if (dealerTC.val > playerTC.val)
                {
                    System.Console.WriteLine("Dealer Wins!");
                }
        }


    }
}
