using System;
class FactorsOfNumber
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine($"Factors of {number} are:");
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
                Console.WriteLine(i);
        }
    }
}
