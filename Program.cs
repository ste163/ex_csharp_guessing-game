using System;

namespace _05_guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = new Random().Next(1, 101);
            Console.WriteLine($"Guess the secret number: {secretNumber}");
            int userGuess = int.Parse(Console.ReadLine());
            int userTries = 4;

            while (userGuess != secretNumber && userTries != 1)
            {
                Console.WriteLine($"Incorrect.");
                if (userGuess < secretNumber)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Guess is too LOW.");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Guess is too HIGH.");
                }
                userTries--;
                Console.WriteLine($"{userTries} out of 4 tries left. Enter a new number:");
                Console.WriteLine("");
                userGuess = int.Parse(Console.ReadLine());
                Console.WriteLine("");
            }

            if (userTries != 1 || userGuess == secretNumber)
            {
                Console.WriteLine($"Correct! The secret number is {secretNumber}");
            }
            else
            {
                Console.WriteLine($"Ran out of tries!");
            }

        }
    }
}
