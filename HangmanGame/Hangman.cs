using static System.Console;

namespace Hangman_game;

internal class Hangman
{
    public static void Main(string[] args)
    {
        string[] words = { "cat", "dog", "bird", "elephant", "tiger" };
        var random = new Random();
        var randomWord = words[random.Next(words.Length)];
        var guessedLetters = new char[randomWord.Length];
        var lives = 6;
        var gameOver = false;

        for (var i = 0; i < guessedLetters.Length; i++) guessedLetters[i] = '_';

        WriteLine("Welcome to Hangman Game!");
        WriteLine("Guess the word by entering one letter at a time.");
        WriteLine("You have 6 lives. Let's begin!");

        while (!gameOver)
        {
            WriteLine("\nWord: {0}", string.Join(" ", guessedLetters));
            WriteLine("Lives: {0}", lives);

            Write("Enter a letter: ");
            var letter = ReadLine().ToLower()[0];

            var letterFound = false;

            for (var i = 0; i < randomWord.Length; i++)
            {
                if (randomWord[i] != letter) continue;
                guessedLetters[i] = letter;
                letterFound = true;
            }

            if (letterFound)
            {
                WriteLine("Good guess!");
            }
            else
            {
                WriteLine("No such letter.");
                lives--;
            }

            if (lives == 0)
            {
                gameOver = true;
                WriteLine("Game Over! You ran out of lives.");
                WriteLine("The word was: {0}", randomWord);
            }

            if (Array.Exists(guessedLetters, c => c == '_')) continue;
            gameOver = true;
            WriteLine("Congratulations! You guessed the word: {0}", randomWord);
        }

        WriteLine("Thanks for playing Hangman. Press any key to exit.");
        ReadKey();
    }
}