using System;

public class StudentVoteChecker
{
    public static bool CanStudentVote(int age)
    {
        if (age < 0) return false;
        return age >= 18;
    }

    public static void Main()
    {
        int[] ages = new int[10];

        for (int i = 0; i < ages.Length; i++)
        {
            Console.Write($"Enter age of student {i + 1}: ");
            ages[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < ages.Length; i++)
        {
            Console.WriteLine($"Student {i + 1}: " + (CanStudentVote(ages[i]) ? "Can Vote" : "Cannot Vote"));
        }
    }
}
