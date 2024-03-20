using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Ask the user to input a string
        Console.WriteLine("Enter a string:");
        string inputString = Console.ReadLine();

        // Use LINQ to find the characters and their frequencies
        var charFrequency = inputString
            .GroupBy(c => c)
            .ToDictionary(g => g.Key, g => g.Count());

        // Display the result
        Console.WriteLine("Character\tFrequency");
        foreach (var kvp in charFrequency)
        {
            Console.WriteLine($"{kvp.Key}\t\t{kvp.Value}");
        }

        // Keep the terminal open until the user presses Enter
        Console.ReadLine();
    }
}
