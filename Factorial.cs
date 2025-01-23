using System;

class Factorial
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        if (number >= 0)
        {
            int factorial = 1;
            while (number > 0)
            {
                factorial *= number;
                number--;
            }
            Console.WriteLine($"Factorial is {factorial}");
        }
    }
}
