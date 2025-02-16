using System;

class RotationPoint
{
    static void Main()
    {
        int[] arr = { 6, 7, 9, 15, 19, 2, 3 };
        int index = FindRotationPoint(arr);
        Console.WriteLine("Rotation point index: " + index);
    }

    static int FindRotationPoint(int[] arr)
    {
        int left = 0, right = arr.Length - 1;
        while (left < right)
        {
            int mid = left + (right - left) / 2;
            if (arr[mid] > arr[right])
            {
                left = mid + 1;
            }
            else
            {
                right = mid;
            }
        }
        return left;
    }
}
