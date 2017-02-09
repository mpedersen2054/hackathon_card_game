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

            while (player.hand.Count > 1 && dealer.hand.Count > 1)
            {
                turnCount++;
                System.Console.WriteLine(turnCount);
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

                // KENNON TODO : Create a new list of cards here, then add each
                // card to list. Pass list of cards(2) into the war method
                War(playerTC, dealerTC);
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

        // KENNON TODO: Make war take a list of cards, instead of 2 cards
        private void War(Card wc1, Card wc2)
        {
            Card playerDown = player.TakeTopCard();
            Card dealerDown = dealer.TakeTopCard();
            Card playerUp = player.TakeTopCard();
            Card dealerUp = dealer.TakeTopCard();

            int puc = playerUp.val;
            int duc = dealerUp.val;

            if (puc == 1) { puc = 14; }
            if (duc == 1) { duc = 14; }

            // if tie
            if (puc == duc)
            {
                System.Console.WriteLine("DOUBLE WARRRRRRRRR!!!!");
            }
            if (puc > duc)
            {
                System.Console.WriteLine("PLAYER WON WARRRRR!!!!");
                player.hand.Add(wc1);
                player.hand.Add(wc2);
                player.hand.Add(playerDown);
                player.hand.Add(playerUp);
                player.hand.Add(dealerDown);
                player.hand.Add(dealerUp);
            }
            if (duc > puc)
            {
                System.Console.WriteLine("DEALER WON WARRRRRR!!!!");
                dealer.hand.Add(wc1);
                dealer.hand.Add(wc2);
                dealer.hand.Add(playerDown);
                dealer.hand.Add(playerUp);
                dealer.hand.Add(dealerDown);
                dealer.hand.Add(dealerUp);
                
            }
            // if player win
            // if dealer win
        }


    }
}
