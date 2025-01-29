using System;

class FibonacciGenerator
{
    static void GenerateFibonacci(int terms)
    {
        int a = 0, b = 1, next;
        Console.Write($"{a} {b} ");
        
        for (int i = 2; i < terms; i++)
        {
            next = a + b;
            Console.Write($"{next} ");
            a = b;
            b = next;
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("Enter number of terms: ");
        int terms = int.Parse(Console.ReadLine());

        GenerateFibonacci(terms);
    }
}
