using System;

class LongestWord
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string[] words = Console.ReadLine().Split(' ');
        string longest = "";

        foreach (string word in words)
        {
            if (word.Length > longest.Length)
                longest = word;
        }

        Console.WriteLine("Longest Word: " + longest);
    }
}
