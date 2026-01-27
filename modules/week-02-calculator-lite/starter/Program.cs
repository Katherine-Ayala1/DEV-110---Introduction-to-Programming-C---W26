namespace CalculatorLite;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Calculator Lite ===\n");

        string userName;
        double num1;
        double num2;
        bool showDecimals;

        int calculationCount = 0;

        Console.Write("Enter your name: ");
        userName = Console.ReadLine();

        Console.WriteLine($"Hello, {userName}!");
        Console.Write("Use decimal precision? (yes/no): ");
        string decimalInput = Console.ReadLine();

        showDecimals = decimalInput == "yes";
        Console.Write("Enter the first number: ");
        num1 = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        num2 = double.Parse(Console.ReadLine());

        // Addition
        double sum = num1 + num2;
        if (showDecimals)
        {
            Console.WriteLine($"Sum: {num1:F2} + {num2:F2} = {sum:F2}");
        }
        else
        {
            Console.WriteLine($"Sum: {num1:F0} + {num2:F0} = {sum:F0}");
        }
        calculationCount++;
        // Subtraction
        double difference = num1 - num2;
        if (showDecimals)
        {
            Console.WriteLine($"Difference: {num1:F2} - {num2:F2} = {difference:F2}");
        }
        else
        {
            Console.WriteLine($"Difference: {num1:F0} - {num2:F0} = {difference:F0}");
        }
        calculationCount++;

        // Multiplication
        double product = num1 * num2;
        if (showDecimals)
        {
            Console.WriteLine($"Product: {num1:F2} * {num2:F2} = {product:F2}");
        }
        else
        {
            Console.WriteLine($"Product: {num1:F0} * {num2:F0} = {product:F0}");
        }
        calculationCount++;
        // Division
        if (num2 != 0)
        {
            double quotient = num1 / num2;
            if (showDecimals)
            {
                Console.WriteLine($"Quotient: {num1:F2} / {num2:F2} = {quotient:F2}");
            }
            else
            {
                Console.WriteLine($"Quotient: {num1:F0} / {num2:F0} = {quotient:F0}");
            }

            calculationCount++;
        }
        else
        {
            Console.WriteLine("Quotient: Cannot divide by zero");
        }
        // Modulus
        if (num2 != 0)
        {
            double remainder = num1 % num2;

            if (showDecimals)
            {
                Console.WriteLine($"Remainder: {num1:F2} % {num2:F2} = {remainder:F2}");
            }
            else
            {
                Console.WriteLine($"Remainder: {num1:F0} % {num2:F0} = {remainder:F0}");
            }

            calculationCount++;
        }
        else
        { Console.WriteLine("Remainder: Cannot divide by zero"); }
        // Average
        double average = (num1 + num2) / 2;
        if (showDecimals)
        {
            Console.WriteLine($"Average: ({num1:F2} + {num2:F2}) / 2 = {average:F2}");
        }
        else
        {
            Console.WriteLine($"Average: ({num1:F0} + {num2:F0}) / 2 = {average:F0}");
        }

        calculationCount++;
        // Percentage Difference
        if (num1 != 0)
        {
            double percentageDifference = ((num1 - num2) / num1) * 100;

            if (showDecimals)
            {
                Console.WriteLine($"Percentage Difference: {percentageDifference:F2}%");
            }
            else
            {
                Console.WriteLine($"Percentage Difference: {percentageDifference:F0}%");
            }

            calculationCount++;
        }
        else
        {
            Console.WriteLine("Percentage Difference: Cannot divide by zero");
        }
        Console.WriteLine($"\nPerformed {calculationCount} calculations for {userName}!");
        Console.WriteLine("\nThank you for using Calculator Lite!");
    }
}
