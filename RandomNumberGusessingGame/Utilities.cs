using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGusessingGame
{
    internal static class Utilities
    {
        internal static void ProgramMenu()
        {
            Console.WriteLine("Welcome to Demmy's Guessing Game \n" +
            "Instructions: In this game, you have 5 guesses to choose the correct number \nbetween 1 and 100." +
                " If you guess is within the right range, you'll be notified. Good Luck!");

            Console.Write("Guess a number from 1 - 100");
            Console.ReadLine();
        }

        internal static void GenerateRandomNumber() 
        { 
            Random rnd = new Random();
            Console.WriteLine(rnd.Next(1, 101));
        }
    }
}
