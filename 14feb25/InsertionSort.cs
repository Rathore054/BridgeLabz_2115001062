using System;

class InsertionSort
{
    static void Sort(int[] ids)
    {
        int n = ids.Length;
        for (int i = 1; i < n; i++)
        {
            int key = ids[i];
            int j = i - 1;
            while (j >= 0 && ids[j] > key)
            {
                ids[j + 1] = ids[j];
                j--;
            }
            ids[j + 1] = key;
        }
    }

    static void Main()
    {
        int[] ids = { 104, 101, 108, 102, 107 };
        Sort(ids);
        Console.WriteLine("Sorted Employee IDs: " + string.Join(", ", ids));
    }
}
