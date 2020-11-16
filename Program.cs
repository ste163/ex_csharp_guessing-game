using System;

namespace _05_guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = new Random().Next(1, 101);   
            int userGuess;
            int userTries = 0;
            int totalTries = 0;
            int difficultyMode = 0;


            while (difficultyMode != 1 && difficultyMode != 2 && difficultyMode != 3)
            {
                Console.WriteLine("Enter a difficulty number:");
                Console.WriteLine("1) Easy - eight guesses");
                Console.WriteLine("2) Medium - six guesses");
                Console.WriteLine("3) Hard - four guesses");

                difficultyMode = int.Parse(Console.ReadLine());

                switch (difficultyMode)
                {
                    case 1:
                        userTries = 8;
                        totalTries = 8;
                        break;
                    case 2:
                        userTries = 6;
                        totalTries = 6;
                        break;
                    case 3:
                        userTries = 4;
                        totalTries = 4;
                        break;
                }
            }

            Console.WriteLine($"You have {totalTries} tries.");
            Console.WriteLine($"Guess the secret number: {secretNumber}");
            userGuess = int.Parse(Console.ReadLine());
            while (userGuess != secretNumber && userTries != 1)
            {
                Console.WriteLine("Incorrect.");
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
                Console.WriteLine($"{userTries} out of {totalTries} tries left. Enter a new number:");
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
