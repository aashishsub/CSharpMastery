using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Number Guessing Game";
            Console.WriteLine("=== Welcome to the Number Guessing Game! ===");
            bool playAgain = true;

            while (playAgain)
            {
                PlayGame();

                Console.Write("\nWould you like to play again? (y/n): ");
                string? answer = Console.ReadLine()?.ToLower();
                playAgain = (answer == "y" || answer == "yes");
            }

            Console.WriteLine("\nThanks for playing! Goodbye!");
        }

        static void PlayGame()
        {
            Random random = new Random();
            int secretNumber = random.Next(1, 101);
            int attempts = 0;
            bool guessedCorrectly = false;

            Console.WriteLine("\nI'm thinking of a number between 1 and 100...");
            while (!guessedCorrectly)
            {
                Console.Write("Enter your guess: ");
                string? input = Console.ReadLine();

                // Validate input
                if (!int.TryParse(input, out int guess))
                {
                    Console.WriteLine("Please enter a valid number.");
                    continue;
                }

                attempts++;

                if (guess < secretNumber)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (guess > secretNumber)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else
                {
                    Console.WriteLine($"Correct! You guessed it in {attempts} attempts.");
                    guessedCorrectly = true;
                }
            }
        }
    }
}
