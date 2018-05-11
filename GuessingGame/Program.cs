using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int val = r.Next(1, 100);
            int guess = 0;
            bool correct = false;

            Console.WriteLine("I'm thinking of a number between 1 and 100.");

            while (!correct)
            {
                Console.Write("Guess: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("That's not a number.");
                    continue;
                }

                if (guess > 100 || guess < 0)
                {
                    Console.WriteLine("That's not even in the right range!");
                }
                else if (guess < val)
                {
                    Console.WriteLine("No, the number I'm thinking is higher than that number.");
                }
                else if (guess > val)
                {
                    Console.WriteLine("No, the number I'm thinking is lower than that number.");
                }
                else
                {
                    correct = true;
                    Console.WriteLine("You guessed right!");
                }
            }
        }
    }
}
