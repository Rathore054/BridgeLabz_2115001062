using System;

public class ChocolateDivider
{
    public static int[] FindRemainderAndQuotient(int chocolates, int children)
    {
        int eachChild = chocolates / children;
        int remaining = chocolates % children;
        return new int[] { eachChild, remaining };
    }

    public static void Main()
    {
        Console.Write("Enter number of chocolates: ");
        int chocolates = int.Parse(Console.ReadLine());

        Console.Write("Enter number of children: ");
        int children = int.Parse(Console.ReadLine());

        int[] result = FindRemainderAndQuotient(chocolates, children);
        Console.WriteLine($"Each child gets {result[0]} chocolates. Remaining: {result[1]}");
    }
}
