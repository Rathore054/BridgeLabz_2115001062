 using System;

public class CollinearPointsChecker
{
    public static void Main()
    {
        Console.WriteLine(CheckCollinear(2, 4, 4, 6, 6, 8));
    }

    public static bool CheckCollinear(int x1, int y1, int x2, int y2, int x3, int y3) => 
        (y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1);
}
