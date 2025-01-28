using System;

public class FactorsUtility
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int[] factors = FindFactors(number);
        Console.WriteLine($"Perfect Number: {factors.Sum() - number == number}");
    }

    public static int[] FindFactors(int n) => Enumerable.Range(1, n / 2).Where(i => n % i == 0).ToArray();
}
