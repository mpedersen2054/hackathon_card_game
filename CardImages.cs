using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class CardImages
    {
        public List<Card> hand;
        public string handString;
        public CardImages(List<Card> _hand)
        {
            hand = _hand;
            handString = GetHandString();
        }
        private string GetHandString()
        {
            string retString = "";

            string[] ri = {
                "┌─────────┐\t",
                "│{0}         │\t",
                "│         │\t",
                "│         │\t",
                "│    {0}     │\t",
                "│         │\t",
                "│         │\t",
                "│       {0}  │\t",
                "└─────────┘\t",
                "    {0}     \t",    
            };

            for (int i = 0; i < 10; i++)
            {
                for (var j = 0; j < hand.Count; j++)
                {
                    int last = hand.Count - 1;
                    if (j == last)
                    {
                        retString += ri[i] + "\n";
                    }
                    else {
                        retString += ri[i];
                    }
                }
            }

            return retString;
        }
    }
}
