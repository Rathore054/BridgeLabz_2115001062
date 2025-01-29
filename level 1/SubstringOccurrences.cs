using System;

class SubstringOccurrences
{
    static void Main()
    {
        Console.Write("Enter the main string: ");
        string text = Console.ReadLine();
        Console.Write("Enter the substring to find: ");
        string substring = Console.ReadLine();

        int count = 0, index = text.IndexOf(substring);
        while (index != -1)
        {
            count++;
            index = text.IndexOf(substring, index + 1);
        }

        Console.WriteLine($"Occurrences: {count}");
    }
}
