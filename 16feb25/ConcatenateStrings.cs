using System;
using System.Text;

class ConcatenateStrings
{
    static void Main()
    {
        string[] strings = { "Hello", " ", "World", "!" };
        StringBuilder sb = new StringBuilder();
        foreach (var str in strings)
        {
            sb.Append(str);
        }
        Console.WriteLine(sb.ToString());
    }
}
