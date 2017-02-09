using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class CardImage
    {
        private string suit;
        private int val;
        public string image;
        public CardImage(string _suit = "Joker", int _val = 0)
        {
            suit = _suit;
            val = _val;
            image = CreateCardImage();
        }

        private string CreateCardImage()
        {
            string s;
            string v;

            // given the suit, give single char symbol
            if (suit == "Clubs") { s = "♣"; }
            else if (suit == "Diamonds") { s = "♦"; }
            else if (suit == "Hearts") { s = "♥"; }
            else if (suit == "Spades") { s = "♠"; }
            else { s = "J"; }

            // given the value give either "# " if < 10
            // or if # > 10 give J, Q, K
            if (val < 10)
            {
                if (val == 0) { v = "L "; }
                else if (val == 1) { v = "A "; }
                else
                {
                    v = $"{val.ToString()} ";
                }
            }
            else
            {
                if (val == 10) { v = "10"; }
                else if (val == 11) { v = "J "; }
                else if (val == 12) { v = "Q "; }
                else if (val == 13) { v = "K "; }
                else { v = "? "; }
            }

            string retImage = "";
                retImage += "┌─────────┐";
                retImage += $"│{v}       │";
                retImage += "│         │";
                retImage += "│         │";
                retImage += $"│    {s}    │";
                retImage += "│         │";
                retImage += "│         │";
                retImage += $"│       {v}│";
                retImage += "└─────────┘";
            // System.Console.WriteLine(retImage);
            return retImage;
        }
    }
}
