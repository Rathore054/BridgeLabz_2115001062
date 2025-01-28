 using System;

public class NumberCheckerUtility3
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int[] digits = StoreDigits(number);
        Console.WriteLine($"Palindrome: {IsPalindrome(digits)}");
    }

    public static int[] StoreDigits(int n) => n.ToString().Select(c => c - '0').ToArray();
    public static bool IsPalindrome(int[] arr) => arr.SequenceEqual(arr.Reverse());
}
