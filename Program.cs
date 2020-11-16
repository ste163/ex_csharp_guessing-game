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

            // While one of the difficulties is not selected, you must select one.
            while (difficultyMode != 1 && difficultyMode != 2 && difficultyMode != 3 && difficultyMode != 4)
            {
                Console.WriteLine("Enter a difficulty number:");
                Console.WriteLine("1) Easy - eight guesses");
                Console.WriteLine("2) Medium - six guesses");
                Console.WriteLine("3) Hard - four guesses");

                difficultyMode = int.Parse(Console.ReadLine());

                // Switch for what difficulty mode was selected.
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
                    case 4:
                        userTries = int.MaxValue;
                        totalTries = int.MaxValue;
                        break; 
                }
            }

            // Tell user how many tries they have.
            Console.WriteLine($"You have {totalTries} tries.");
            Console.Write($"Guess the secret number: ");
            // Allow user to enter int
            userGuess = int.Parse(Console.ReadLine());

            // While the user has not guessed the secret number,
            // and while they have anything other than 1 try left,
            // allow them to guess.
            while (userGuess != secretNumber && userTries != 1)
            {
                Console.WriteLine("Incorrect.");
                // Give user a hint on if they guess too low or high.
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
                // Remove one of the user's tries.
                userTries--;
                // Tell user how many tries are left.
                Console.Write($"{userTries} out of {totalTries} tries left. Enter a new number: ");
                // Let the user guess again.
                userGuess = int.Parse(Console.ReadLine());
                Console.WriteLine("");
            }

            // If the user has turns left, and they guess the secret number, they won!
            if (userTries != 1 || userGuess == secretNumber)
            {
                Console.WriteLine($"Correct! The secret number is {secretNumber}");
            }
            // If the user runs out of tries, they lose!
            else
            {
                Console.WriteLine($"Ran out of tries!");
            }
        }
    }
}
