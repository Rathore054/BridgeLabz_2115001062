using System;

class SearchFirstNegative
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, -1, 4, 5 };
        int index = SearchFirstNegativeNumber(arr);
        Console.WriteLine(index == -1 ? "No negative number found." : $"First negative number at index {index}");
    }

    static int SearchFirstNegativeNumber(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 0)
            {
                return i;
            }
        }
        return -1;
    }
}
