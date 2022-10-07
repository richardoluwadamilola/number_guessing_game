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

        }
    }
}
