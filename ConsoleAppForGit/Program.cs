using System;
using System.Collections.Generic;

namespace ConsoleAppForGit
{
    class Program
    {

        static double Add10(double num)
        {
            return num + 10;
        }

        static int Add10(int num)
        {
            return num + 10;
        }

        static void Main(string[] args)
        {
            Console.Write("Schreiben Sie bitte ein Nummer herunter: ");
            int nummer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Der Nummer, der Sie geschrieben haben, ist: " + nummer);
        
        }
    }
}

/* 
 
     var CorrectAnswer = "81";
            Console.Write("What is 9*9: ");
            var a = Console.ReadLine();
            Console.WriteLine("The following has been answered: " + a);
            if(a == "81")
            {
                Console.WriteLine(a + " is true!");
            }
            else
            {
                Console.WriteLine("Answer " + a + " is wrong. Correct answer is: " + CorrectAnswer);
            }
        }

      private static void OutputThreeCards()
        {
            Console.WriteLine("--------------> Playing a game round...");
            Deck deck = new Deck();
            deck.ShuffleDeck();
            List<Card> threeCards = deck.DisplayThreeCards();
            deck.GetResult(threeCards);
        }

        private static bool ContinuePlaying()
        {
            Console.WriteLine("******** Press 2 to restart. Otherwise enter a number except 2 to quit. *********");
            int input = int.Parse(Console.ReadLine());
            return ((input == 2) ? true : false); 

        }

        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LuckyCard game!");
            bool keepPlaying = true;
            while (keepPlaying)
            {
                OutputThreeCards();
                keepPlaying = ContinuePlaying();

            }
            if(keepPlaying == false)
            {
                Console.WriteLine("Thank you for playing!");
            }

        }
     
     */
