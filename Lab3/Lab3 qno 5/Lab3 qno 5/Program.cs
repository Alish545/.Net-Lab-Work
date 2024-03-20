using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // List of cities
        List<string> cities = new List<string> { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEWDELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

        // Character to check for start and end
        char startChar = 'A';
        char endChar = 'S';

        Console.WriteLine($"Cities starting with '{startChar}' and ending with '{endChar}':");

        // Iterate through the cities and check for the specified character at start and end
        foreach (string city in cities)
        {
            if (city.StartsWith(startChar) || city.EndsWith(endChar))
            {
                Console.WriteLine(city);
            }
        }
    }
}
