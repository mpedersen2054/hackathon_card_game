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
        private int turnCount;
        public Game(Player playr, Player dealr)
        {
            player = playr;
            dealer = dealr;
            turnCount = 0;

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

            while (player.hand.Count > 8 && dealer.hand.Count > 8)
            {
                turnCount++;
                System.Console.WriteLine(turnCount);
                PlayCards();
            }
            if (player.hand.Count > dealer.hand.Count)
            {
                System.Console.WriteLine("\n\n==============");
                System.Console.WriteLine("PLAYER WON THE GAME!!!");
                System.Console.WriteLine("==============");
            }
            else
            {
                System.Console.WriteLine("\n\n==============");
                System.Console.WriteLine("DEALER WON THE GAME!!!");
                System.Console.WriteLine("==============");
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
                List<Card> warList = new List<Card>();
                warList.Add(playerTC);
                warList.Add(dealerTC);
                War(warList);
                
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

        // KENNON TODO: Make war take a list of cards, instead of 2 cards
        private void War(List<Card> warList)
        {
            Card pd1 = player.TakeTopCard();
            Card pd2 = player.TakeTopCard();
            Card pd3 = player.TakeTopCard();
            Card pu = player.TakeTopCard();

            Card dd1 = player.TakeTopCard();
            Card dd2 = player.TakeTopCard();
            Card dd3 = player.TakeTopCard();
            Card du = player.TakeTopCard();

            warList.Add(pd1);
            warList.Add(pd2);
            warList.Add(pd3);
            warList.Add(pu);
            warList.Add(dd1);
            warList.Add(dd2);
            warList.Add(dd3);
            warList.Add(du);

            int puc = pu.val;
            int duc = du.val;

            if (puc == 1) { puc = 14; }
            if (duc == 1) { duc = 14; }

            // if tie
            if (puc == duc)
            {
                War(warList);
            }
            if (puc > duc)
            {
                foreach (Card card in warList)
                {
                    player.hand.Add(card);
                }
            }
            if (duc > puc)
            {
                foreach (Card card in warList)
                {
                    dealer.hand.Add(card);
                }
            }
        }

    }
}
