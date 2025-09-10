using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask user for their age
        Console.Write("Enter your age: ");
        string input = Console.ReadLine() ?? "0";

        if (int.TryParse(input, out int age) && age > 0)
        {
            // Calculate max heart rate
            int maxHeartRate = 220 - age;

            // Show result
            Console.WriteLine($"Your estimated maximum heart rate is {maxHeartRate} beats per minute.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid age (positive number).");
        }

        // Keep console window open
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
