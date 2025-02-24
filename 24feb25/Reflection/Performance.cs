using System;
using System.Diagnostics;
using System.Reflection;

class Performance
{
    public void HeavyTask()
    {
        Stopwatch sw = Stopwatch.StartNew();
        for (int i = 0; i < 1000000; i++) { }
        sw.Stop();
        Console.WriteLine($"Execution Time: {sw.ElapsedMilliseconds} ms");
    }
}

class TimingTest
{
    static void Main()
    {
        Performance p = new Performance();
        MethodInfo method = typeof(Performance).GetMethod("HeavyTask");

        Stopwatch sw = Stopwatch.StartNew();
        method.Invoke(p, null);
        sw.Stop();
        Console.WriteLine($"Measured Execution Time: {sw.ElapsedMilliseconds} ms");
    }
}
