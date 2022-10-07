using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your name?");

            // get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a number guessing game", inputName);

            // number to be guessed
            int NumGuessed = 7;

            // guess variable
            int guess = 0;

            Console.WriteLine("Guess a number between 1 and 10");

            // how the game is to be played
            while (guess != NumGuessed)
            {
                string input = Console.ReadLine();

                guess = Int32.Parse(input);

                if (guess != NumGuessed)
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("wrong number, please try again");

                    Console.ResetColor();
                }

                if (guess == NumGuessed)
                {
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine("You are correct,Good game");

                    Console.ResetColor();

                    // Ask to play again
                    Console.WriteLine("Do you want to play again, {Y or N}");

                    Console.ReadLine();               
                }
            }
        }
    }
}
