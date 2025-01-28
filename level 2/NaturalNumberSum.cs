using System;

public class NaturalNumberSum
{
    public static int RecursiveSum(int n)
    {
        if (n == 0) return 0;
        return n + RecursiveSum(n - 1);
    }

    public static int FormulaSum(int n)
    {
        return n * (n + 1) / 2;
    }

    public static void Main()
    {
        Console.Write("Enter a natural number: ");
        int n = int.Parse(Console.ReadLine());
        if (n <= 0)
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        int recursiveSum = RecursiveSum(n);
        int formulaSum = FormulaSum(n);

        Console.WriteLine("Recursive Sum: " + recursiveSum);
        Console.WriteLine("Formula Sum: " + formulaSum);
    }
}
