using static System.Console;

namespace Guessing_Game;

internal class GuessNumber
{
    public static void Main(string[] args)
    {
        var playAgain = true;

        while (playAgain)
        {
            var secretNumber = new Random().Next(0, 50);
            var attempts = 0;
            var correctGuess = false;

            WriteLine("Welcome to the Guessing Game!");

            while (!correctGuess)
            {
                Write("Enter your guess (between 0 and 50): ");
                var guess = Convert.ToInt32(ReadLine());
                attempts++;

                if (guess < secretNumber)
                {
                    WriteLine("My number is bigger..");
                }
                else if (guess > secretNumber)
                {
                    WriteLine("My number is smaller..");
                }
                else
                {
                    correctGuess = true;
                    WriteLine("Bullseye!");
                }
            }

            WriteLine("Congratulations! You guessed the number {0} correctly!", secretNumber);
            WriteLine("It took you {0} attempts.", attempts);

            Write("Do you want to play again? (yes/no): ");
            var playAgainInput = ReadLine().ToLower();
            playAgain = playAgainInput is "yes" or "y";

            WriteLine();
        }

        WriteLine("Thanks for playing. Press any key to exit.");
        ReadKey();
    }
}