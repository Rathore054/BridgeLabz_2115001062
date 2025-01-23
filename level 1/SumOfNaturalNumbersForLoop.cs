using System;

class SumOfNaturalNumbersForLoop
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        if (number > 0)
        {
            int sum = 0;
            for (int i = 1; i <= number; i++) sum += i;
            int formulaSum = number * (number + 1) / 2;
            Console.WriteLine($"Sum using loop: {sum}, Sum using formula: {formulaSum}");
        }
        else
        {
            Console.WriteLine($"{number} is not a natural number");
        }
    }
}
