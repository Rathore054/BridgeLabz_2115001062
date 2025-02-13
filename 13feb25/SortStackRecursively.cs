using System;
using System.Collections.Generic;

public class SortStackRecursively
{
    public static void SortStack(Stack<int> stack)
    {
        if (stack.Count > 0)
        {
            int top = stack.Pop();
            SortStack(stack);
            InsertInSortedOrder(stack, top);
        }
    }

    private static void InsertInSortedOrder(Stack<int> stack, int element)
    {
        if (stack.Count == 0 || stack.Peek() <= element)
            stack.Push(element);
        else
        {
            int temp = stack.Pop();
            InsertInSortedOrder(stack, element);
            stack.Push(temp);
        }
    }
}
