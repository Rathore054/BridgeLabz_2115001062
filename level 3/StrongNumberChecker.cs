using System;

public class StrongNumberChecker
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine($"Strong Number: {IsStrongNumber(number)}");
    }

    public static bool IsStrongNumber(int n)
    {
        int[] digits = StoreDigits(n);
        int sum = 0;
        foreach (var digit in digits)
            sum += Factorial(digit);
        return sum == n;
    }

    public static int[] StoreDigits(int n) => n.ToString().Select(c => c - '0').ToArray();

    public static int Factorial(int num)
    {
        int fact = 1;
        for (int i = 2; i <= num; i++)
            fact *= i;
        return fact;
    }
}
