using System;

public class RandomNumberAnalysis
{
    public static int[] GenerateRandomNumbers(int size)
    {
        Random random = new Random();
        int[] numbers = new int[size];

        for (int i = 0; i < size; i++)
            numbers[i] = random.Next(1000, 10000);

        return numbers;
    }

    public static (double avg, int min, int max) FindStats(int[] numbers)
    {
        int sum = 0, min = int.MaxValue, max = int.MinValue;

        foreach (int number in numbers)
        {
            sum += number;
            if (number < min) min = number;
            if (number > max) max = number;
        }

        return ((double)sum / numbers.Length, min, max);
    }

    public static void Main()
    {
        int[] numbers = GenerateRandomNumbers(5);

        Console.WriteLine("Random Numbers: " + string.Join(", ", numbers));
        var stats = FindStats(numbers);

        Console.WriteLine("Average: " + stats.avg);
        Console.WriteLine("Minimum: " + stats.min);
        Console.WriteLine("Maximum: " + stats.max);
    }
}
