using System;

class PeakElement
{
    static void Main()
    {
        int[] arr = { 1, 3, 20, 4, 1 };
        int index = FindPeakElement(arr);
        Console.WriteLine($"Peak element is {arr[index]} at index {index}");
    }

    static int FindPeakElement(int[] arr)
    {
        int left = 0, right = arr.Length - 1;
        while (left < right)
        {
            int mid = left + (right - left) / 2;
            if (arr[mid] > arr[mid + 1])
            {
                right = mid;
            }
            else
            {
                left = mid + 1;
            }
        }
        return left;
    }
}
