using System;
using System.Text;

class ReverseString
{
    static void Main()
    {
        string input = "hello";
        StringBuilder sb = new StringBuilder(input);
        sb = ReverseString(sb);
        Console.WriteLine(sb.ToString());
    }

    static StringBuilder ReverseString(StringBuilder sb)
    {
        StringBuilder reversed = new StringBuilder();
        for (int i = sb.Length - 1; i >= 0; i--)
        {
            reversed.Append(sb[i]);
        }
        return reversed;
    }
}
