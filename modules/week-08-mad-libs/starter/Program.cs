/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: Katherine Ayala
- Assignment: Week 8: Mad Libs (Structure + Debugging)
-
- What does this program do?:
- Runs a two-template Mad Libs app that practices structure and debugging.
- */

namespace MadLibs;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Mad Libs: Structure + Debugging ===");
        Console.WriteLine();

        bool playAgain;
        do
        {
            StoryTemplate template = ChooseTemplate();
            Console.WriteLine();

            string[] words = CollectWords(template);

            string story = template.GenerateStory(words);
            Console.WriteLine(story);
            Console.WriteLine();

            playAgain = ReadYesNo("Play again? (y/n): ");
            Console.WriteLine();
        }
        while (playAgain);
    }


    private static StoryTemplate ChooseTemplate()
    {
        while (true)
        {
            Console.WriteLine("Choose a template:");
            Console.WriteLine("1) Debugging at the Zoo");
            Console.WriteLine("2) The Standup Meeting");

            Console.Write("Enter choice (1-2): ");
            string input = Console.ReadLine() ?? string.Empty;


            if (int.TryParse(input, out int choice) && choice >= 1 && choice <= 2)
            {
                if (choice == 1)
                {
                    return new StoryTemplate(
                        "Debugging at the Zoo",
                        new[]
                        {
                            "adjective",
                            "animals",
                            "-ing verb",
                            "language",
                            "tool",
                            "number",
                            "emotion",
                            "exclamation",
                        },
                        "One day at the zoo, I saw {1} {2} excitedly. It was a very {0} moment. I opened {3}, grabbed my {4}, tried {5} times, felt {6}, and shouted \"{7}!\""
                    );
                }
                return new StoryTemplate(
                    "The Standup Meeting",
                    new[]
                    {
                        "name",
                        "adjective",
                        "noun",
                        "past tense verb",
                        "number",
                        "plural noun",
                        "bug",
                        "snack",
                    },
                    "While checking email, {0} saw a {1} message about the {2} that {3}. After reading {4} {5}, they discovered a {6} and celebrated with {7}."
                );
            }

            Console.WriteLine("Please enter a number between 1 and 2.");
        }
    }

    private static string[] CollectWords(StoryTemplate template)
    {
        Logger.Info($"Collecting {template.Prompts.Length} words for: {template.Title}");
        string[] words = new string[template.Prompts.Length];

        for (int i = 0; i < template.Prompts.Length; i++)
        {
            words[i] = ReadNonEmptyString($"Enter a(n) {template.Prompts[i]}: ");
        }
        Console.WriteLine();
        return words;
    }


    private static bool ReadYesNo(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);

            string input = (Console.ReadLine() ?? string.Empty)
                .Trim()
                .ToLowerInvariant();
            if (input == "y")
            {
                return true;
            }
            if (input == "n")
            {
                return false;
            }
            Console.WriteLine("Please enter 'y' or 'n'.");
        }
    }


    private static int ReadIntInRange(string prompt, int min, int max)
    {
        int value;

        do
        {
            Console.Write(prompt);

            string input = Console.ReadLine() ?? string.Empty;

            if (int.TryParse(input, out value) && value >= min && value <= max)
            {
                return value;
            }
            Console.WriteLine($"Please enter a number between {min} and {max}.");
        }
        while (true);
    }


    private static string ReadNonEmptyString(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = (Console.ReadLine() ?? string.Empty).Trim();

            if (!string.IsNullOrWhiteSpace(input))
            {
                return input;
            }
            Console.WriteLine("Input cannot be empty. Please try again.");
        }
    }
}
