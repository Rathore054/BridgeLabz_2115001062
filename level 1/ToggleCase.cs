using System;

class ToggleCase
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        char[] toggled = new char[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            char ch = input[i];
            toggled[i] = char.IsUpper(ch) ? char.ToLower(ch) : char.ToUpper(ch);
        }

        Console.WriteLine("Toggled String: " + new string(toggled));
    }
}
