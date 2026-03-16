using System.Data;

namespace GuessTheNumber;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Guess the Number: Loop Trio ===\n");

        // Asks user for a max number between 10 and 100 / number of rounds (1-3)
        int maxValue = ReadIntInRange("Enter a max value (10-100): ", 10, 100);
        int rounds = ReadIntInRange("How many rounds? (1-3): ", 1, 3);

        // repeats rounds depending on how many selected
        for (int round = 1; round <= rounds; round++)
        {
            //displays round # and generates a secret number. Guessing loop starts.
            Console.WriteLine($"\nRound {round} of {rounds}");
            Random random = new Random(maxValue + round);
            int secret = random.Next(1, maxValue + 1);
            int guess = 0;
            int guessCount = 0;
            while (guess != secret)
            {
                //asks user to guess a number
                Console.Write($"Guess a number (1-{maxValue}): ");
                string? input = Console.ReadLine();
                bool isNumber = int.TryParse(input, out guess);
                if (!isNumber)
                {
                    continue;
                }
                if (guess < 1 || guess > maxValue)
                {
                    continue;
                }
                guessCount++;

                if (guess < secret)
                {
                    Console.WriteLine("Too low.");
                }
                else if (guess > secret)
                {
                    Console.WriteLine("Too high.");
                }
                else
                {
                    Console.WriteLine($"Correct! You got it in {guessCount} guesses.");
                }

            }
        }
        //exit message
        Console.WriteLine("Thanks for playing!");
    }
    private static int ReadIntInRange(string prompt, int min, int max)
    {
        int value;
        bool isValid;

        do

        {
            Console.Write(prompt);
            string? input = Console.ReadLine();
            isValid = int.TryParse(input, out value);

        } while (!isValid || value < min || value > max);

        return value;
    }
}
