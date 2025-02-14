using System;

class BubbleSort
{
    static void Sort(int[] marks)
    {
        int n = marks.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (marks[j] > marks[j + 1])
                {
                   
                    int temp = marks[j];
                    marks[j] = marks[j + 1];
                    marks[j + 1] = temp;
                }
            }
        }
    }

    static void Main()
    {
        int[] marks = { 78, 55, 89, 91, 67, 72 };
        Sort(marks);
        Console.WriteLine("Sorted Marks: " + string.Join(", ", marks));
    }
}
