
using System;
class MarksAndGrade
{
    public static void Main(string[] args)
    {
        Console.Write("Enter marks for Physics: ");
        int physics = int.Parse(Console.ReadLine());
        Console.Write("Enter marks for Chemistry: ");
        int chemistry = int.Parse(Console.ReadLine());
        Console.Write("Enter marks for Maths: ");
        int maths = int.Parse(Console.ReadLine());
        int totalMarks = physics + chemistry + maths;
        double percentage = totalMarks / 3.0;
        string grade, remarks;
        if (percentage >= 90)
        {
            grade = "A+";
            remarks = "Excellent";
        }
        else if (percentage >= 80)
        {
            grade = "A";
            remarks = "Very Good";
        }
        else if (percentage >= 70)
        {
            grade = "B+";
            remarks = "Good";
        }
        else if (percentage >= 60)
        {
            grade = "B";
            remarks = "Average";
        }
        else if (percentage >= 50)
        {
            grade = "C";
            remarks = "Below Average";
        }
        else
        {
            grade = "F";
            remarks = "Fail";
        }
        Console.WriteLine($"\nTotal Marks: {totalMarks}");
        Console.WriteLine($"Percentage: {percentage:F2}%");
        Console.WriteLine($"Grade: {grade}");
        Console.WriteLine($"Remarks: {remarks}");
    }
}

