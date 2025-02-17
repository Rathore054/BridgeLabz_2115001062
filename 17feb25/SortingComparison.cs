using System;
using System.Diagnostics;

class SortingComparison
{
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
            for (int j = 0; j < n - i - 1; j++)
                if (arr[j] > arr[j + 1])
                    (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
    }

    static void MergeSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2;
            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);
            Merge(arr, left, mid, right);
        }
    }

    static void Merge(int[] arr, int left, int mid, int right)
    {
        int[] leftArr = arr[left..(mid + 1)];
        int[] rightArr = arr[(mid + 1)..(right + 1)];
        int i = 0, j = 0, k = left;

        while (i < leftArr.Length && j < rightArr.Length)
            arr[k++] = leftArr[i] <= rightArr[j] ? leftArr[i++] : rightArr[j++];
        while (i < leftArr.Length) arr[k++] = leftArr[i++];
        while (j < rightArr.Length) arr[k++] = rightArr[j++];
    }

    static void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(arr, low, high);
            QuickSort(arr, low, pi - 1);
            QuickSort(arr, pi + 1, high);
        }
    }

    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high], i = low - 1;
        for (int j = low; j < high; j++)
            if (arr[j] < pivot)
                (arr[++i], arr[j]) = (arr[j], arr[i]);
        (arr[i + 1], arr[high]) = (arr[high], arr[i + 1]);
        return i + 1;
    }

    public static void Main()
    {
        int[] sizes = { 1000, 10000 }; // 1,000,000 would take too long for Bubble Sort
        Random rand = new Random();

        foreach (int size in sizes)
        {
            int[] data = new int[size];
            for (int i = 0; i < size; i++)
                data[i] = rand.Next(size);

            int[] arrBubble = (int[])data.Clone();
            int[] arrMerge = (int[])data.Clone();
            int[] arrQuick = (int[])data.Clone();

            Stopwatch sw = new Stopwatch();
            sw.Start();
            if (size <= 10000) BubbleSort(arrBubble); 
            sw.Stop();
            Console.WriteLine($"Bubble Sort (N={size}): {sw.ElapsedMilliseconds}ms");

            sw.Restart();
            MergeSort(arrMerge, 0, arrMerge.Length - 1);
            sw.Stop();
            Console.WriteLine($"Merge Sort (N={size}): {sw.ElapsedMilliseconds}ms");
            sw.Restart();
            QuickSort(arrQuick, 0, arrQuick.Length - 1);
            sw.Stop();
            Console.WriteLine($"Quick Sort (N={size}): {sw.ElapsedMilliseconds}ms");

            Console.WriteLine();
        }
    }
}
