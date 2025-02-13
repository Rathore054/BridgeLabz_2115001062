using System;
using System.Collections.Generic;

public class ZeroSumSubarrays
{
    public static List<Tuple<int, int>> FindZeroSumSubarrays(int[] arr)
    {
        Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
        List<Tuple<int, int>> result = new List<Tuple<int, int>>();
        int sum = 0;
        
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];

            if (sum == 0)
                result.Add(Tuple.Create(0, i));

            if (map.ContainsKey(sum))
            {
                foreach (int index in map[sum])
                    result.Add(Tuple.Create(index + 1, i));
            }

            if (!map.ContainsKey(sum))
                map[sum] = new List<int>();

            map[sum].Add(i);
        }
        return result;
    }
}
