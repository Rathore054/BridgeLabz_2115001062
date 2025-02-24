using System;
using System.Diagnostics;

[AttributeUsage(AttributeTargets.Method)]
class LogExecutionTime : Attribute { }

class PerformanceMonitor
{
    [LogExecutionTime]
    public void ExpensiveOperation()
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        System.Threading.Thread.Sleep(500);
        stopwatch.Stop();
        Console.WriteLine($"Execution Time: {stopwatch.ElapsedMilliseconds} ms");
    }

    static void Main()
    {
        PerformanceMonitor monitor = new PerformanceMonitor();
        monitor.ExpensiveOperation();
    }
}
