 using System;

public class FootballTeamStats
{
    public static void Main()
    {
        int[] heights = new int[11];
        Random random = new Random();
        for (int i = 0; i < heights.Length; i++)
            heights[i] = random.Next(150, 251);

        int shortest = FindShortest(heights);
        int tallest = FindTallest(heights);
        double mean = FindMean(heights);

        Console.WriteLine($"Shortest Height: {shortest} cm");
        Console.WriteLine($"Tallest Height: {tallest} cm");
        Console.WriteLine($"Mean Height: {mean:F2} cm");
    }

    public static int FindShortest(int[] arr) => Array.Min(arr);
    public static int FindTallest(int[] arr) => Array.Max(arr);
    public static double FindMean(int[] arr) => (double)Array.Sum(arr) / arr.Length;
}
