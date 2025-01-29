using System;

class CountVowelsConsonants
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine().ToLower();

        int vowels = 0, consonants = 0;
        string vowelChars = "aeiou";

        foreach (char ch in input)
        {
            if (char.IsLetter(ch))
            {
                if (vowelChars.Contains(ch))
                    vowels++;
                else
                    consonants++;
            }
        }

        Console.WriteLine($"Vowels: {vowels}, Consonants: {consonants}");
    }
}
