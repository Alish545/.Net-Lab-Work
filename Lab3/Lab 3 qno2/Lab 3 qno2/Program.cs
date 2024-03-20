using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Ask the user to input a string
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        // Use LINQ to find the uppercase letters in the string
        var uppercaseLetters = input.Where(char.IsUpper);

        // Display the result
        Console.WriteLine("Uppercase letters in the string:");
        foreach (char letter in uppercaseLetters)
        {
            Console.Write($"{letter} ");
        }

        // Keep the terminal open until the user presses Enter
        Console.ReadLine();
    }
}
