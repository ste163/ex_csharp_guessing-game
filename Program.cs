using System;

namespace _05_guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = 43;
            Console.WriteLine("Guess the secret number:");
            int userGuess = int.Parse(Console.ReadLine());
            int userTries = 0;

            while (userGuess != secretNumber && userTries < 3)
            {
                Console.WriteLine($"Incorrect.");
                userTries++;
                Console.WriteLine($"{userTries} out of 4 tries left. Enter a new number:");
                Console.WriteLine("");
                userGuess = int.Parse(Console.ReadLine());
                Console.WriteLine("");
            }

            if (userTries < 3 || userGuess == secretNumber)
            {
                Console.WriteLine($"Correct! The secret number is {secretNumber}");
            }
            else
            {
                Console.WriteLine("Ran out of tries!");
            }

        }
    }
}
