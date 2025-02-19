using System;
using System.Collections.Generic;

class word
{
    static Dictionary<string, int> CountWords(string text)
    {
        Dictionary<string, int> wordCount = new Dictionary<string, int>();
        string[] words = text.ToLower().Split(new char[] { ' ', ',', '!', '.' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (var word in words)
        {
            if (wordCount.ContainsKey(word))
                wordCount[word]++;
            else
                wordCount[word] = 1;
        }
        return wordCount;
    }

    static void Main()
    {
        string input = "Hello world, hello Java!";
        Dictionary<string, int> frequency = CountWords(input);

        foreach (var kvp in frequency)
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
    }
}
