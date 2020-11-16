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
            int userTries = 1;
            while (userGuess != secretNumber && userTries < 4)
            {
                Console.WriteLine($"Incorrect! You guessed {userGuess}. Try again!");
                userGuess = int.Parse(Console.ReadLine());
                userTries++;
            }

            if (userTries < 4)
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
