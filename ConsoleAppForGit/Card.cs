using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppForGit
{
    class Card
    {
        private string Suit;
        private int Rank;
        private int Value;

        public Card(string Suit, int Rank)
        {
            this.Suit = Suit;
            this.Rank = Rank;
            
            if(GetSuit() == "Diamonds")
            {
                Value += 4 + Rank;
            }
            else if (GetSuit() == "Clubs")
            {
                Value += 6 + Rank;
            }
            else if (GetSuit() == "Hearts")
            {
                Value += 8 + Rank;
            }
            else if (GetSuit() == "Spades")
            {
                Value += 10 + Rank;
            }
        }

        public string GetSuit()
        {
            return Suit;
        }

        public int GetRank()
        {
            return Rank;
        }

        public int GetValue()
        {
            return Value;
        }
    }
}
