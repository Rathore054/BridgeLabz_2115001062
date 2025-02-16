using System;
using System.IO;

class CountWordOccurrence
{
    static void Main()
    {
        string path = "example.txt";
        string wordToFind = "hello";
        int count = 0;

        using (StreamReader sr = new StreamReader(path))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                count += CountWordInLine(line, wordToFind);
            }
        }

        Console.WriteLine($"The word '{wordToFind}' occurs {count} times.");
    }

    static int CountWordInLine(string line, string word)
    {
        int count = 0;
        int index = 0;
        while ((index = line.IndexOf(word, index)) != -1)
        {
            count++;
            index += word.Length;
        }
        return count;
    }
}
