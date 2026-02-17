/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: Katherine Ayala Reyes
- Assignment: Week 6: Text Menu App
-
- What does this program do?:
- Runs a text-heavy menu app that demonstrates string formatting and output patterns.
- */

using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

namespace TextMenuApp;

public class Program
{
    public static void Main(string[] args)
    {
        // Title banner using strings
        string title = "Text Menu Studio";
        string subtitle = "Strings + Console Output Patterns";
        string divider = new string('=', 48);
        Console.WriteLine(divider);
        Console.WriteLine(title.ToUpper());
        Console.WriteLine(subtitle);
        Console.WriteLine(divider);
        int choice = 0;

        while (choice != 6)
        {
            // Menu box
            Console.WriteLine("1) Greeting Card");
            Console.WriteLine("2) Name Tag Formatter");
            Console.WriteLine("3) Phrase Analyzer");
            Console.WriteLine("4) Fancy Receipt Line");
            Console.WriteLine("5) Menu Banner Builder");
            Console.WriteLine("6) Exit");

            // Menu Choice from user
            choice = ReadIntInRange("Choose an option (1-6): ", 1, 6);
            switch (choice)
            {
                case 1:
                    {
                        Console.Write("Enter your name: ");
                        string name = (Console.ReadLine() ?? "").Trim();
                        string upperName = name.ToUpper();

                        Console.Write("Enter a short message: ");
                        string message = Console.ReadLine() ?? "";

                        string border = new string('-', 40);
                        Console.WriteLine(border);
                        Console.WriteLine($"Hello, {name}!".PadRight(40));
                        Console.WriteLine(string.Format("Uppercase: {0}", upperName).PadRight(40));
                        Console.WriteLine(("Message: " + message).PadRight(40));
                        Console.WriteLine(border);
                        break;
                    }

                case 2:
                    {
                        Console.Write("Enter first name: ");
                        string first = (Console.ReadLine() ?? "").Trim();

                        Console.Write("Enter last name: ");
                        string last = (Console.ReadLine() ?? "").Trim();

                        string full = first + " " + last;
                        char fi = first.Length > 0 ? first[0] : '?';
                        char li = last.Length > 0 ? last[0] : '?';
                        string initials = (fi.ToString() + li.ToString()).ToUpper();

                        Console.WriteLine($"Name Tag: [{full}]");
                        Console.WriteLine($"Initials: {initials}");
                        Console.WriteLine($"Lowercase: {full.ToLower()}");
                        break;
                    }

                case 3:
                    {
                        Console.Write("Enter a phrase: ");
                        string phrase = (Console.ReadLine() ?? "").Trim();

                        Console.WriteLine($"Length: {phrase.Length}");

                        bool hasA = phrase.ToLower().Contains('a');
                        Console.WriteLine($"Contains 'a': {hasA}");

                        string dashed = phrase.Replace(" ", "-");
                        Console.WriteLine($"Dashed: {dashed}");

                        string[] words = phrase.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                        string list = string.Join(", ", words);
                        Console.WriteLine($"Words: {list}");
                        break;
                    }

                case 4:
                    {
                        Console.Write("Enter item name: ");
                        string item = (Console.ReadLine() ?? "").Trim();

                        double price = ReadDouble("Enter price: ");
                        int qty = ReadIntInRange("Enter quantity (1-9): ", 1, 9);

                        double total = price * qty;

                        Console.WriteLine("ITEM                QTY        TOTAL");
                        Console.WriteLine(new string('-', 40));
                        Console.WriteLine(string.Format("{0,-20}{1,5}{2,13:C2}", item, qty, total));
                        break;
                    }

                case 5:
                    {
                        Console.Write("Enter a title: ");
                        string bTitle = (Console.ReadLine() ?? string.Empty).Trim();

                        Console.Write("Enter a subtitle: ");
                        string bSub = (Console.ReadLine() ?? string.Empty).Trim();

                        int width = ReadIntInRange("Enter width (30-60): ", 30, 60);
                        string border = new string('=', width);

                        string upperTitle = bTitle.ToUpper();
                        int titlePad = (width + upperTitle.Length) / 2;
                        int subPad = (width + bSub.Length) / 2;

                        Console.WriteLine(border);
                        Console.WriteLine(upperTitle.PadLeft(titlePad));
                        Console.WriteLine(bSub.PadLeft(subPad));
                        Console.WriteLine(border);

                        Console.WriteLine($"Centered: {upperTitle.PadLeft(titlePad)}");
                        Console.WriteLine($"Left: {upperTitle.PadRight(width)}");
                        Console.WriteLine($"Right: {upperTitle.PadLeft(width)}");
                        break;
                    }

                case 6:
                    {
                        Console.Write("Enter a closing word: ");
                        string closing = (Console.ReadLine() ?? string.Empty).Trim();

                        bool eq = closing.Equals("goodbye", StringComparison.OrdinalIgnoreCase);
                        string first3 = closing.Length >= 3 ? closing.Substring(0, 3) : closing;
                        string first3Lower = first3.ToLower();

                        bool endsBang = closing.EndsWith("!");
                        int spacePos = closing.IndexOf(' ');

                        Console.WriteLine($"Equals 'goodbye': {eq}");
                        Console.WriteLine($"First 3: '{first3Lower}'");
                        Console.WriteLine($"Ends with !: {endsBang}");
                        Console.WriteLine($"Index of space: {spacePos}");

                        Console.WriteLine("Goodbye!");
                        break;
                    }
            }

            if (choice != 6)
            {
                Console.WriteLine();
            }
        }
    }

    private static int ReadIntInRange(string prompt, int min, int max)
    {
        int value;
        bool ok;

        do
        {
            Console.Write(prompt);
            string input = Console.ReadLine() ?? "";
            ok = int.TryParse(input, out value);

            if (!ok || value < min || value > max)
            {
                ok = false;
                Console.WriteLine($"Please enter a whole number from {min} to {max}.");
            }
        } while (!ok);

        return value;
    }

    private static double ReadDouble(string prompt)
    {
        double value;
        bool ok;

        do
        {
            Console.Write(prompt);
            string input = Console.ReadLine() ?? "";
            ok = double.TryParse(input, out value);

            if (!ok)
            {
                Console.WriteLine("Please enter a valid number.");
            }

        } while (!ok);

        return value;
    }
}
