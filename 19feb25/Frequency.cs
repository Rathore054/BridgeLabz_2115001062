using System;
using System.Collections.Generic;

class Frequency
{
    static Dictionary<string, int> GetFrequency(List<string> list)
    {
        Dictionary<string, int> frequency = new Dictionary<string, int>();
        foreach (var item in list)
        {
            if (frequency.ContainsKey(item))
                frequency[item]++;
            else
                frequency[item] = 1;
        }
        return frequency;
    }

    static void Main()
    {
        List<string> words = new List<string> { "apple", "banana", "apple", "orange" };
        var frequency = GetFrequency(words);
        foreach (var kvp in frequency)
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
    }
}
