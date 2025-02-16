

using System;
using System.Text;

class RemoveDuplicates
{
    static void Main()
    {
        string input = "aabbccddeeff";
        StringBuilder sb = new StringBuilder();
        sb = RemoveDuplicatesFromString(input);
        Console.WriteLine(sb.ToString());
    }

    static StringBuilder RemoveDuplicatesFromString(string input)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < input.Length; i++)
        {
            if (sb.ToString().IndexOf(input[i]) == -1)
            {
                sb.Append(input[i]);
            }
        }
        return sb;
    }
}

