using System;
using System.Collections.Generic;

class Rotate
{
    static List<int> RotateList(List<int> list, int k)
    {
        int n = list.Count;
        k = k % n;
        List<int> rotated = new List<int>(list.GetRange(k, n - k));
        rotated.AddRange(list.GetRange(0, k));
        return rotated;
    }

    static void Main()
    {
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
        int rotateBy = 2;
        List<int> rotatedList = RotateList(numbers, rotateBy);
        Console.WriteLine(string.Join(", ", rotatedList));
    }
}
