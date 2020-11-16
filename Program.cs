using System;

namespace _05_guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the secret number:");
            string userGuess = Console.ReadLine();
            Console.WriteLine($"You guessed: {userGuess}");
        }
    }
}
