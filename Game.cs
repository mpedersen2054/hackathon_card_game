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

            int pcv = playerTC.val;
            int dcv = dealerTC.val;

            if (pcv == 1) { pcv = 14; }
            if (dcv == 1) { dcv = 14; }

            // Player and Dealer tie
            if (pcv == dcv)
            {
                System.Console.WriteLine("Cards are Tied! Play0ff");
                // method should be written for playoff
            }
            // Player Card is > Dealer Card
            if (pcv > dcv)
            {
                System.Console.WriteLine("Player Wins!");
                player.hand.Add(playerTC);
                player.hand.Add(dealerTC);
            }
            // Dealer Card is > Player Card
            if (dcv > pcv)
            {
                System.Console.WriteLine("Dealer Wins!");
                dealer.hand.Add(playerTC);
                dealer.hand.Add(dealerTC);
            }

            System.Console.WriteLine("Player card: {0} :: Player hand {1}", pcv, player.hand.Count);
            System.Console.WriteLine("Dealer card: {0} :: Dealer hand {1}", dcv, dealer.hand.Count);
            System.Console.WriteLine("===================");
        }


    }
}
