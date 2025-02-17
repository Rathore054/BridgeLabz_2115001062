using System;
using System.Diagnostics;

class SearchComparison
{
    static int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
                return i;
        }
        return -1;
    }

    static int BinarySearch(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (arr[mid] == target)
                return mid;
            else if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return -1;
    }

    public static void Main()
    {
        int[] sizes = { 1000, 10000, 1000000 };
        Random rand = new Random();

        foreach (int size in sizes)
        {
            int[] data = new int[size];
            for (int i = 0; i < size; i++)
                data[i] = i;

            int target = rand.Next(size); 

            Stopwatch sw = new Stopwatch();
            sw.Start();
            LinearSearch(data, target);
            sw.Stop();
            Console.WriteLine($"Linear Search (N={size}): {sw.ElapsedMilliseconds}ms");
            sw.Restart();
            BinarySearch(data, target);
            sw.Stop();
            Console.WriteLine($"Binary Search (N={size}): {sw.ElapsedMilliseconds}ms");
            Console.WriteLine();
        }
    }
}
