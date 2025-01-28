using System;

public class NumberAnalyzer
{
    public static bool IsPositive(int number) => number >= 0;

    public static bool IsEven(int number) => number % 2 == 0;

    public static int CompareNumbers(int num1, int num2)
    {
        if (num1 > num2) return 1;
        if (num1 < num2) return -1;
        return 0;
    }

    public static void Main()
    {
        int[] numbers = new int[5];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        foreach (int number in numbers)
        {
            if (IsPositive(number))
            {
                Console.WriteLine(number + " is Positive " + (IsEven(number) ? "and Even" : "and Odd"));
            }
            else
            {
                Console.WriteLine(number + " is Negative");
            }
        }

        int comparison = CompareNumbers(numbers[0], numbers[^1]);
        string result = comparison == 1 ? "First > Last" : comparison == -1 ? "First < Last" : "First = Last";
        Console.WriteLine("Comparison of First and Last Elements: " + result);
    }
}
