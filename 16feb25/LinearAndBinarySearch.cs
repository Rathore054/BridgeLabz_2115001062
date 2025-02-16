using System;

class LinearAndBinarySearch
{
    static void Main()
    {
        int[] arr = { 3, 4, -1, 1 };
        int missingPositive = FindFirstMissingPositive(arr);
        Console.WriteLine($"First missing positive: {missingPositive}");

        Array.Sort(arr);
        int target = 4;
        int targetIndex = BinarySearch(arr, target);
        Console.WriteLine(targetIndex != -1 ? $"Target {target} found at index {targetIndex}" : "Target not found");
    }

    static int FindFirstMissingPositive(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; i++)
        {
            while (arr[i] > 0 && arr[i] <= n && arr[arr[i] - 1] != arr[i])
            {
                int temp = arr[arr[i] - 1];
                arr[arr[i] - 1] = arr[i];
                arr[i] = temp;
            }
        }
        for (int i = 0; i < n; i++)
        {
            if (arr[i] != i + 1)
            {
                return i + 1;
            }
        }
        return n + 1;
    }

    static int BinarySearch(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (arr[mid] == target) return mid;
            if (arr[mid] < target) left = mid + 1;
            else right = mid - 1;
        }
        return -1;
    }
}
