using System;

class ReplaceWord
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();
        Console.Write("Enter word to replace: ");
        string oldWord = Console.ReadLine();
        Console.Write("Enter new word: ");
        string newWord = Console.ReadLine();

        string modifiedSentence = sentence.Replace(oldWord, newWord);
        Console.WriteLine("Modified Sentence: " + modifiedSentence);
    }
}
