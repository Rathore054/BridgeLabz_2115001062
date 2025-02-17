using System;
using System.Diagnostics;

class FibonacciComparison
{
        static int FibonacciRecursive(int n)
    {
        if (n <= 1) return n;
        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }
    static int FibonacciIterative(int n)
    {
        if (n <= 1) return n;
        int a = 0, b = 1, sum;
        for (int i = 2; i <= n; i++)
        {
            sum = a + b;
            a = b;
            b = sum;
        }
        return b;
    }

    public static void Main()
    {
        int[] testCases = { 10, 30, 50 };
        Stopwatch sw = new Stopwatch();

        foreach (int n in testCases)
        {
            if (n <= 30)             {
                sw.Start();
                int recResult = FibonacciRecursive(n);
                sw.Stop();
                Console.WriteLine($"Recursive Fibonacci (N={n}): {sw.ElapsedMilliseconds}ms, Result={recResult}");
            }
            else
            {
                Console.WriteLine($"Recursive Fibonacci (N={n}): Unfeasible (>1hr)");
            }
            sw.Restart();
            int iterResult = FibonacciIterative(n);
            sw.Stop();
            Console.WriteLine($"Iterative Fibonacci (N={n}): {sw.ElapsedMilliseconds}ms, Result={iterResult}");

            Console.WriteLine();
        }
    }
}
