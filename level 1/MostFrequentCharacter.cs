using System;
using System.Linq;

class MostFrequentCharacter
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        var mostFrequent = input.GroupBy(c => c)
                                .OrderByDescending(g => g.Count())
                                .First().Key;

        Console.WriteLine($"Most Frequent Character: '{mostFrequent}'");
    }
}
