using System;

class RemoveCharacter
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        Console.Write("Enter character to remove: ");
        char removeChar = Console.ReadLine()[0];

        string modified = input.Replace(removeChar.ToString(), "");
        Console.WriteLine("Modified String: " + modified);
    }
}
