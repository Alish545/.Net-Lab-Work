using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Ask the user to input student marks
        Console.WriteLine("Enter the student marks (comma-separated):");
        string input = Console.ReadLine();

        // Convert the input string to a list of integers
        List<int> studentMarks = input.Split(',')
                                      .Select(str => int.Parse(str.Trim()))
                                      .ToList();

        // Use LINQ to find the number of students with marks greater than 80
        int count = studentMarks.Count(mark => mark > 80);

        // Display the result
        Console.WriteLine($"Number of students with marks greater than 80: {count}");

        // Keep the terminal open until the user presses Enter
        Console.ReadLine();
    }
}
