using System;

public class FactorsCalculator
{
    public static int[] FindFactors(int number)
    {
        int count = 0;
        for (int i = 1; i <= number; i++)
            if (number % i == 0) count++;

        int[] factors = new int[count];
        int index = 0;

        for (int i = 1; i <= number; i++)
            if (number % i == 0) factors[index++] = i;

        return factors;
    }

    public static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int[] factors = FindFactors(number);

        int sum = 0, product = 1, sumOfSquares = 0;

        foreach (int factor in factors)
        {
            sum += factor;
            product *= factor;
            sumOfSquares += factor * factor;
        }

        Console.WriteLine("Factors: " + string.Join(", ", factors));
        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Product: " + product);
        Console.WriteLine("Sum of Squares: " + sumOfSquares);
    }
}
