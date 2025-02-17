using System;
using System.Text;
using System.Diagnostics;

class StringConcatenationComparison
{
    static void StringConcatenation(int n)
    {
        string result = "";
        for (int i = 0; i < n; i++)
            result += "a";     }

    static void StringBuilderConcatenation(int n)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < n; i++)
            sb.Append("a");
    }

    static void StringBufferConcatenation(int n)
    {
        StringBuilder sb = new StringBuilder();
        object lockObj = new object();

        for (int i = 0; i < n; i++)
        {
            lock (lockObj)             {
                sb.Append("a");
            }
        }
    }

    public static void Main()
    {
        int[] sizes = { 1000, 10000, 1000000 };
        
        foreach (int size in sizes)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            StringConcatenation(size);
            sw.Stop();
            Console.WriteLine($"String (N={size}): {sw.ElapsedMilliseconds}ms");
            sw.Restart();
            StringBuilderConcatenation(size);
            sw.Stop();
            Console.WriteLine($"StringBuilder (N={size}): {sw.ElapsedMilliseconds}ms");
            sw.Restart();
            StringBufferConcatenation(size);
            sw.Stop();
            Console.WriteLine($"StringBuffer (N={size}): {sw.ElapsedMilliseconds}ms");

            Console.WriteLine();
        }
    }
}
