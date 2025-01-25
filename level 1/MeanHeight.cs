class MeanHeight
{
    static void Main()
    {
        double[] heights = new double[11];
        double total = 0.0;

        for (int i = 0; i < heights.Length; i++)
        {
            Console.Write($"Enter the height of player {i + 1}: ");
            heights[i] = double.Parse(Console.ReadLine());
            total += heights[i];
        }

        double mean = total / heights.Length;
        Console.WriteLine($"Mean height of players: {mean:F2}");
    }
}

