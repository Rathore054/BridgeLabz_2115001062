using System;
using System.Collections.Generic;

class Binary
{
    static List<string> GenerateBinaryNumbers(int n)
    {
        List<string> result = new List<string>();
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("1");

        for (int i = 0; i < n; i++)
        {
            string s = queue.Dequeue();
            result.Add(s);
            queue.Enqueue(s + "0");
            queue.Enqueue(s + "1");
        }
        return result;
    }

    static void Main()
    {
        int n = 5;
        List<string> binaryNumbers = GenerateBinaryNumbers(n);
        Console.WriteLine(string.Join(", ", binaryNumbers));
    }
}
