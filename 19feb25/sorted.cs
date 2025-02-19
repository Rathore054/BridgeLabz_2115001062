using System;
using System.Collections.Generic;
using System.Linq;

class sorted
{
    static List<int> ConvertSetToSortedList(HashSet<int> set)
    {
        List<int> sortedList = set.ToList();
        sortedList.Sort();
        return sortedList;
    }

    static void Main()
    {
        HashSet<int> numbers = new HashSet<int> { 5, 3, 9, 1 };
        List<int> sortedList = ConvertSetToSortedList(numbers);

        Console.WriteLine(string.Join(", ", sortedList));
    }
}
