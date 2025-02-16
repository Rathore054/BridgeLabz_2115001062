using System;
using System.Text;
using System.Diagnostics;

class CompareStringBuilderPerformance
{
    static void Main()
    {
        int numIterations = 10000;
        Stopwatch stopwatch = new Stopwatch();

        stopwatch.Start();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < numIterations; i++)
        {
            sb.Append("Hello");
        }
        stopwatch.Stop();
        Console.WriteLine("StringBuilder Time: " + stopwatch.ElapsedMilliseconds + " ms");
    }
}
