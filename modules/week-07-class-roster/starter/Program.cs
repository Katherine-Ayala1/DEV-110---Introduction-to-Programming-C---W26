/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: Katherine Ayala
- Assignment: Week 7: Class Roster Builder (Arrays)
-
- What does this program do?:
- Builds a class roster using parallel arrays and a simple menu.
- */

namespace ClassRoster;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Class Roster ===");
        Console.WriteLine();

        const int rosterCapacity = 3;
        string[] rosterNames = new string[rosterCapacity];
        int[] rosterCredits = new int[rosterCapacity];
        int count = 0;
        int choice = 0;

        while (choice != 4)
        {
            Console.WriteLine("1) Add multiple students");
            Console.WriteLine("2) Print class roster");
            Console.WriteLine("3) Print roster (sorted)");
            Console.WriteLine("4) Exit");

            choice = ReadIntInRange("Choose an option: ", 1, 4);
            switch (choice)
            {
                case 1:
                    if (count == rosterCapacity)
                    {
                        Console.WriteLine("Roster is full. Cannot add more students.");
                        Console.WriteLine();
                        break;
                    }
                    int remainingSlots = rosterCapacity - count;

                    int numberToAdd = ReadIntInRange($"How many students do you want to add? (1-{remainingSlots}): ", 1, remainingSlots);

                    string[] newNames = new string[numberToAdd];
                    int[] newCredits = new int[numberToAdd];

                    for (int i = 0; i < numberToAdd; i++)
                    {
                        Console.Write($"Enter name for student {i + 1}: ");
                        newNames[i] = Console.ReadLine()?.Trim() ?? "";

                        newCredits[i] = ReadIntInRange($"Enter credits for {newNames[i]} (0-200): ", 0, 200);

                    }

                    for (int i = 0; i < numberToAdd; i++)
                    {
                        rosterNames[count] = newNames[i];
                        rosterCredits[count] = newCredits[i];
                        count++;
                    }
                    Console.WriteLine("Students added.");
                    Console.WriteLine();
                    break;

                case 2:
                    if (count == 0)
                    {
                        Console.WriteLine("Roster is empty.");
                        Console.WriteLine();
                        break;
                    }
                    Console.WriteLine("Class Roster:");
                    string[] lines = BuildRosterLines(rosterNames, rosterCredits, count);

                    foreach (string line in lines)
                    {
                        Console.WriteLine(line);
                    }
                    Console.WriteLine();
                    break;

                case 3:
                    if (count == 0)
                    {
                        Console.WriteLine("Roster is empty.");
                        Console.WriteLine();
                        break;
                    }

                    Console.WriteLine("Sort by:");
                    Console.WriteLine("1) Name");
                    Console.WriteLine("2) Credits");

                    int sortChoice = ReadIntInRange("Choose an option: ", 1, 2);

                    CopyUsedRoster(rosterNames, rosterCredits, count, out string[] sortedNames, out int[]
                     sortedCredits);

                    if (sortChoice == 1)
                    {
                        Array.Sort(sortedNames, sortedCredits, StringComparer.OrdinalIgnoreCase);
                    }
                    else
                    {
                        Array.Sort(sortedCredits, sortedNames);
                    }
                    Console.WriteLine("Class Roster (Sorted):");
                    string[] sortedLines = BuildRosterLines(sortedNames, sortedCredits, count);

                    foreach (string line in sortedLines)
                    {
                        Console.WriteLine(line);
                    }
                    Console.WriteLine();
                    break;

                case 4:
                    Console.WriteLine("Goodbye.");
                    break;
            }
        }

    }

    private static int ReadIntInRange(string prompt, int min, int max)
    {
        int value;
        bool isValid;

        do
        {
            Console.Write(prompt);
            string input = Console.ReadLine() ?? string.Empty;
            isValid = int.TryParse(input, out value);
        }
        while (!isValid || value < min || value > max);

        return value;
    }


    private static string[] BuildRosterLines(string[] names, int[] credits, int count)
    {
        string[] lines = new string[count];

        for (int i = 0; i < count; i++)
        {
            lines[i] = $"{names[i]} - {credits[i]} credits";
        }

        return lines;
    }

    private static void CopyUsedRoster(
        string[] sourceNames,
        int[] sourceCredits,
        int count,
        out string[] names,
        out int[] credits)
    {
        names = new string[count];
        credits = new int[count];

        for (int i = 0; i < count; i++)
        {
            names[i] = sourceNames[i];
            credits[i] = sourceCredits[i];
        }
    }
}
