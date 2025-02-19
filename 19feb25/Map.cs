using System;
using System.Collections.Generic;

class Map
{
    static Dictionary<int, List<string>> InvertMap(Dictionary<string, int> map)
    {
        Dictionary<int, List<string>> inverted = new Dictionary<int, List<string>>();

        foreach (var kvp in map)
        {
            if (!inverted.ContainsKey(kvp.Value))
                inverted[kvp.Value] = new List<string>();

            inverted[kvp.Value].Add(kvp.Key);
        }
        return inverted;
    }

    static void Main()
    {
        Dictionary<string, int> input = new Dictionary<string, int>
        {
            { "A", 1 },
            { "B", 2 },
            { "C", 1 }
        };

        var invertedMap = InvertMap(input);
        foreach (var kvp in invertedMap)
        {
            Console.WriteLine($"{kvp.Key}: [{string.Join(", ", kvp.Value)}]");
        }
    }
}
