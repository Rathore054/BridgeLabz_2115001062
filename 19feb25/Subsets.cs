using System;
using System.Collections.Generic;

class Subsets
{
    static bool IsSubset(HashSet<int> subset, HashSet<int> set)
    {
        return set.IsSupersetOf(subset);
    }

    static void Main()
    {
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 4 };
        HashSet<int> set2 = new HashSet<int> { 2, 3 };
        Console.WriteLine(IsSubset(set2, set1));
    }
}
