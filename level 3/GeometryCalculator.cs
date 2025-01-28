 using System;

public class GeometryCalculator
{
    public static void Main()
    {
        Console.WriteLine(CalculateDistance(1, 1, 4, 5));
    }

    public static double CalculateDistance(int x1, int y1, int x2, int y2) => Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
}
