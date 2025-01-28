using System;

public class NaturalNumberSum
{
    public static int CalculateSum(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        return sum;
    }

    public static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        int sum = CalculateSum(n);
        Console.WriteLine($"The sum of {n} natural numbers is {sum}");
    }
}
