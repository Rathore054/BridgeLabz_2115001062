using System;

class SelectionSort
{
    static void Sort(int[] scores)
    {
        int n = scores.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIdx = i;
            for (int j = i + 1; j < n; j++)
            {
                if (scores[j] < scores[minIdx]) minIdx = j;
            }
            (scores[i], scores[minIdx]) = (scores[minIdx], scores[i]);
        }
    }

    static void Main()
    {
        int[] scores = { 85, 90, 70, 60, 80 };
        Sort(scores);
        Console.WriteLine("Sorted Exam Scores: " + string.Join(", ", scores));
    }
}
