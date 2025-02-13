using System;
using System.Collections.Generic;

public class PairWithGivenSum
{
    public static bool HasPairWithSum(int[] arr, int target)
    {
        HashSet<int> seen = new HashSet<int>();
        foreach (int num in arr)
        {
            if (seen.Contains(target - num))
                return true;
            seen.Add(num);
        }
        return false;
    }
}
