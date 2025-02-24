using System;
using System.Collections.Generic;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class CacheResult : Attribute { }

class ExpensiveComputation
{
    private static Dictionary<string, object> cache = new Dictionary<string, object>();

    [CacheResult]
    public int ComputeSquare(int number)
    {
        string key = $"Square-{number}";
        if (cache.ContainsKey(key))
        {
            Console.WriteLine("Returning cached result...");
            return (int)cache[key];
        }

        Console.WriteLine("Computing...");
        int result = number * number;
        cache[key] = result;
        return result;
    }

    static void Main()
    {
        ExpensiveComputation obj = new ExpensiveComputation();

        Console.WriteLine(obj.ComputeSquare(5)); // Computation
        Console.WriteLine(obj.ComputeSquare(5)); // Cached Result
        Console.WriteLine(obj.ComputeSquare(10)); // Computation
        Console.WriteLine(obj.ComputeSquare(10)); // Cached Result
    }
}
