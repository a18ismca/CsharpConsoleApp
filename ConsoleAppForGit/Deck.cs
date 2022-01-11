using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleAppForGit
{
    class Deck
    {
        private List<Card> DeckWithCards = new List<Card>(); 

        public Deck()
        {
            string[] Suit = new string[] { "Diamonds", "Clubs", "Hearts", "Spades" };
            int[] Rank = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

            for (int i = 0; i < Suit.Length; i++)
            {
                for(int j = 0; i < Rank.Length; j++)
                {
                    DeckWithCards.Add(new Card(Suit[i], Rank[j]));
                }
            }
        }
        
        public List<Card> DisplayThreeCards()
        {
            List<Card> ThreeCards = new List<Card>();
            for (int i = 0; i <= 2; i++)
            {
                Card Picked = DeckWithCards[51 - i];
                Console.WriteLine("Card " + (i + 1) + ": " + Picked.GetSuit() + " " + Picked.GetRank() + " ---> Value = " + Picked.GetValue());
                ThreeCards.Add(Picked);
            }
            return ThreeCards;
        }

        public void ShuffleDeck()
        {
            var rnd = new Random();
            var randomized = DeckWithCards.OrderBy(item => rnd.Next());
        }

        public void GetResult(List<Card> threeCards)
        {
            if (threeCards[2].GetValue() > threeCards[1].GetValue() && threeCards[2].GetValue() < threeCards[0].GetValue() || threeCards[2].GetValue() < threeCards[1].GetValue() && threeCards[2].GetValue() > threeCards[0].GetValue())
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("You lose!");
            }
        }
        
        //rank
        //two loops

        //displayThreeCards
        //pick a card
        //print card
        //return

        //winOrLose
    }
}
