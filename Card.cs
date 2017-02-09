using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Card
    {
        public string stringVal;
        public string suit;
        public int val;
        public string fullName;
        public CardImage imageString;
        public Card(string _suit, int _val)
        {
            suit = _suit;
            val = _val;
            stringVal = getStringVal(_val);
            fullName = stringVal + " of " + suit; // Ace of Spades

            // testing!
            imageString = new CardImage(_suit, _val);

        }

        string getStringVal(int val)
        {
            if (val == 1) { return "Ace"; }
            else if (val == 2)  { return "Two"; }
            else if (val == 3)  { return "Three"; }
            else if (val == 4)  { return "Four"; }
            else if (val == 5)  { return "Five"; }
            else if (val == 6)  { return "Six"; }
            else if (val == 7)  { return "Seven"; }
            else if (val == 8)  { return "Eight"; }
            else if (val == 9)  { return "Nine"; }
            else if (val == 10) { return "Ten"; }
            else if (val == 11) { return "Jack"; }
            else if (val == 12) { return "Queen"; }
            else if (val == 13) { return "King"; }
            else { return "???"; }
        }
    }
}
