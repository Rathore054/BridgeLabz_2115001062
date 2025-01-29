using System;
using System.Linq;

class AnagramCheck
{
    static void Main()
    {
        Console.Write("Enter first string: ");
        string str1 = Console.ReadLine();
        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine();

        bool isAnagram = str1.Length == str2.Length &&
                         str1.OrderBy(c => c).SequenceEqual(str2.OrderBy(c => c));

        Console.WriteLine(isAnagram ? "Anagrams" : "Not Anagrams");
    }
}
