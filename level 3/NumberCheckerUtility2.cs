using System;

public class NumberCheckerUtility2
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int[] digits = StoreDigits(number);
        Console.WriteLine($"Sum of Digits: {digits.Sum()}");
        Console.WriteLine($"Sum of Squares of Digits: {digits.Sum(d => d * d)}");
        Console.WriteLine($"Harshad Number: {number % digits.Sum() == 0}");
    }

    public static int[] StoreDigits(int n) => n.ToString().Select(c => c - '0').ToArray();
}
