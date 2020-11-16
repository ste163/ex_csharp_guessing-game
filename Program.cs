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
            while (userGuess != secretNumber)
            {
                Console.WriteLine($"Incorrect! You guessed {userGuess}. Try again!");
                userGuess = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Correct! The secret number is {secretNumber}");
        }
    }
}
