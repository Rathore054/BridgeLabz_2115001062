using System;
using System.Collections;
using System.Collections.Generic;

class reverse
{
    static void ReverseArrayList(ArrayList list)
    {
        int left = 0, right = list.Count - 1;
        while (left < right)
        {
            object temp = list[left];
            list[left] = list[right];
            list[right] = temp;
            left++;
            right--;
        }
    }

    static LinkedList<T> ReverseLinkedList<T>(LinkedList<T> list)
    {
        LinkedList<T> reversedList = new LinkedList<T>();
        foreach (var item in list)
        {
            reversedList.AddFirst(item);
        }
        return reversedList;
    }

    static void Main()
    {
        ArrayList arrList = new ArrayList() { 1, 2, 3, 4, 5 };
        ReverseArrayList(arrList);
        Console.WriteLine("Reversed ArrayList: " + string.Join(", ", arrList.ToArray()));

        LinkedList<int> linkedList = new LinkedList<int>(new int[] { 1, 2, 3, 4, 5 });
        LinkedList<int> reversedLinkedList = ReverseLinkedList(linkedList);
        Console.WriteLine("Reversed LinkedList: " + string.Join(", ", reversedLinkedList));
    }
}
