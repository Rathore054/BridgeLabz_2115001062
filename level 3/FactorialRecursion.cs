using System;

class FactorialRecursion
{
    static long Factorial(int n)
    {
        return (n == 0 || n == 1) ? 1 : n * Factorial(n - 1);
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine($"Factorial: {Factorial(num)}");
    }
}
