using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Ask the user to input numbers (comma-separated)
        Console.WriteLine("Enter a list of numbers (comma-separated):");
        string input = Console.ReadLine();

        // Convert the input string to an array of integers
        int[] numbers = input.Split(',')
                             .Select(str => int.Parse(str.Trim()))
                             .ToArray();

        // Use LINQ to find the numbers and their squares
        var result = numbers.Select(n => new { Number = n, Square = n * n });

        // Display the result
        Console.WriteLine("Number\tSquare");
        foreach (var item in result)
        {
            Console.WriteLine($"{item.Number}\t{item.Square}");
        }

        Console.ReadLine(); // Keep the terminal open
    }
}
