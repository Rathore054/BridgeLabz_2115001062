using System;

class SearchWordInSentences
{
    static void Main()
    {
        string[] sentences = { "Hello world", "This is C#", "Search word here" };
        string word = "C#";
        int index = SearchForWord(sentences, word);
        Console.WriteLine(index == -1 ? "Word not found." : $"Word found at index {index}");
    }

    static int SearchForWord(string[] sentences, string word)
    {
        for (int i = 0; i < sentences.Length; i++)
        {
            if (sentences[i].Contains(word))
            {
                return i;
            }
        }
        return -1;
    }
}
