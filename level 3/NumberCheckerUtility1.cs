using System;

public class NumberCheckerUtility1
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int[] digits = StoreDigits(number);

        Console.WriteLine($"Digit Count: {digits.Length}");
        Console.WriteLine($"Duck Number: {IsDuckNumber(digits)}");
        Console.WriteLine($"Armstrong Number: {IsArmstrongNumber(digits, number)}");
        var largestAndSecond = FindLargestAndSecondLargest(digits);
        Console.WriteLine($"Largest: {largestAndSecond[0]}, Second Largest: {largestAndSecond[1]}");
    }

    public static int[] StoreDigits(int n) => n.ToString().Select(c => c - '0').ToArray();
    public static bool IsDuckNumber(int[] digits) => digits.Any(d => d == 0);
    public static bool IsArmstrongNumber(int[] digits, int n) => digits.Sum(d => (int)Math.Pow(d, digits.Length)) == n;
    public static int[] FindLargestAndSecondLargest(int[] arr)
    {
        int max = int.MinValue, secondMax = int.MinValue;
        foreach (var num in arr)
        {
            if (num > max) { secondMax = max; max = num; }
            else if (num > secondMax) secondMax = num;
        }
        return new[] { max, secondMax };
    }
}
