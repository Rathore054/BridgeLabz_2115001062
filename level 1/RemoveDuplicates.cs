using System;
using System.Text;

class RemoveDuplicates
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        StringBuilder result = new StringBuilder();
        HashSet<char> seen = new HashSet<char>();

        foreach (char ch in input)
        {
            if (!seen.Contains(ch))
            {
                seen.Add(ch);
                result.Append(ch);
            }
        }

        Console.WriteLine("Modified String: " + result);
    }
}
