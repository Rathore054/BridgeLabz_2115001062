using System;
using System.Collections.Generic;

public class SlidingWindowMax
{
    public static int[] MaxSlidingWindow(int[] nums, int k)
    {
        if (nums.Length == 0) return new int[0];
        LinkedList<int> deque = new LinkedList<int>();
        List<int> result = new List<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (deque.Count > 0 && deque.First.Value < i - k + 1)
                deque.RemoveFirst();

            while (deque.Count > 0 && nums[deque.Last.Value] <= nums[i])
                deque.RemoveLast();

            deque.AddLast(i);

            if (i >= k - 1)
                result.Add(nums[deque.First.Value]);
        }
        return result.ToArray();
    }
}
