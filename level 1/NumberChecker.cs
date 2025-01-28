using System;

public class NumberChecker
{
    public static int CheckNumber(int number)
    {
        if (number > 0) return 1;
        if (number < 0) return -1;
        return 0;
    }

    public static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int result = CheckNumber(number);
        string message = result == 1 ? "Positive" : result == -1 ? "Negative" : "Zero";
        Console.WriteLine($"The number is {message}");
    }
}

