using System;

class FactorialForLoop
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        if (number >= 0)
        {
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"Factorial is {factorial}");
        }
    }
}
