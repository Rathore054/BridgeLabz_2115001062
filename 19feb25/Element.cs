using System;
using System.Collections.Generic;

class Element
{
    static string FindNthFromEnd(LinkedList<string> list, int n)
    {
        LinkedListNode<string> first = list.First;
        LinkedListNode<string> second = list.First;

        for (int i = 0; i < n; i++)
        {
            if (first == null) return "Invalid N";
            first = first.Next;
        }

        while (first != null)
        {
            first = first.Next;
            second = second.Next;
        }
        return second.Value;
    }

    static void Main()
    {
        LinkedList<string> linkedList = new LinkedList<string>(new string[] { "A", "B", "C", "D", "E" });
        int n = 2;
        Console.WriteLine(FindNthFromEnd(linkedList, n));
    }
}
