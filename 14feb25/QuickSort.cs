using System;

class QuickSort
{
    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high], i = low - 1;
        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                (arr[i], arr[j]) = (arr[j], arr[i]);
            }
        }
        (arr[i + 1], arr[high]) = (arr[high], arr[i + 1]);
        return i + 1;
    }

    static void Sort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(arr, low, high);
            Sort(arr, low, pi - 1);
            Sort(arr, pi + 1, high);
        }
    }

    static void Main()
    {
        int[] prices = { 1500, 800, 2000, 1200, 1800 };
        Sort(prices, 0, prices.Length - 1);
        Console.WriteLine("Sorted Product Prices: " + string.Join(", ", prices));
    }
}
