using System;

class CountingSort
{
    static void Sort(int[] ages)
    {
        int max = 18, min = 10;
        int range = max - min + 1;
        int[] count = new int[range];
        int[] output = new int[ages.Length];

        foreach (var age in ages) count[age - min]++;
        for (int i = 1; i < range; i++) count[i] += count[i - 1];

        for (int i = ages.Length - 1; i >= 0; i--)
            output[--count[ages[i] - min]] = ages[i];

        Array.Copy(output, ages, ages.Length);
    }

    static void Main()
    {
        int[] ages = { 15, 12, 18, 14, 10, 17, 11, 16, 13 };
        Sort(ages);
        Console.WriteLine("Sorted Ages: " + string.Join(", ", ages));
    }
}
