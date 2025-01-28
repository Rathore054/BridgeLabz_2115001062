using System;

public class NumberCheckerUtility4
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine($"Prime: {IsPrime(number)}");
    }

    public static bool IsPrime(int n) => n > 1 && Enumerable.Range(2, (int)Math.Sqrt(n) - 1).All(i => n % i != 0);
}
