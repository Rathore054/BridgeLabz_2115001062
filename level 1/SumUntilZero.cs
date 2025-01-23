using System;

class SumUntilZero
{
    static void Main()
    {
        double total = 0.0;
        double value;
        while ((value = double.Parse(Console.ReadLine())) != 0)
        {
            total += value;
        }
        Console.WriteLine($"Total sum is {total}");
    }
}
