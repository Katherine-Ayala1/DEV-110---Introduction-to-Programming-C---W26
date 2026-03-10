/*******************************************************************************
- Course: DEV 110
- Instructor: Zak Brinlee
- Term: Winter 2026
-
- Programmer: Katherine Ayala
- Assignment: Week 9: Score Stats (Methods + LINQ)
-
- What does this program do?:
- Defines a ScoreReport class students complete using LINQ methods.
- */

using System.Globalization;
using System.Linq;

namespace ScoreStats;

internal class ScoreReport
{
    private readonly int[] _scores;

    public ScoreReport(int[] scores, int threshold)
    {
        _scores = scores;
        Threshold = threshold;
    }

    public int Threshold { get; }

    public int Count => _scores.Length;


    public void PrintReport()
    {
        PrintBasicStats();
        PrintPassingFailingCounts();
        Console.WriteLine();
        PrintScoresSorted();
        PrintTopScores(3);
        PrintPassingScores();
        PrintFailingScores();
    }
    private void PrintBasicStats()
    {
        int min = _scores.Min();
        int max = _scores.Max();
        double avg = _scores.Average();

        Console.WriteLine($"Count: {Count}");
        Console.WriteLine($"Min: {min}");
        Console.WriteLine($"Max: {max}");
        Console.WriteLine($"Average: {avg.ToString("0.0", CultureInfo.InvariantCulture)}");
    }

    private void PrintPassingFailingCounts()
    {
        int passing = _scores.Count(score => score >= Threshold);
        int failing = _scores.Count(score => score < Threshold);

        Console.WriteLine($"Passing (>={Threshold}): {passing}");
        Console.WriteLine($"Failing (<{Threshold}): {failing}");
    }

    private void PrintScoresSorted()
    {
        var sorted = _scores.OrderBy(score => score);
        Console.WriteLine($"Sorted (asc): {string.Join(", ", sorted)}");
    }


    private void PrintTopScores(int topCount)
    {
        var top = _scores
           .OrderByDescending(score => score)
           .Take(topCount);

        Console.WriteLine($"Top {topCount}: {string.Join(", ", top)}");
    }

    private void PrintPassingScores()
    {
        var passingScores = _scores
            .Where(score => score >= Threshold)
            .OrderByDescending(score => score);

        Console.WriteLine($"Passing scores (desc): {string.Join(", ", passingScores)}");
    }

    private void PrintFailingScores()
    {
        var failingScores = _scores
            .Where(score => score < Threshold)
            .OrderByDescending(score => score);
        Console.WriteLine($"Failing scores (desc): {string.Join(", ", failingScores)}");
    }
}
