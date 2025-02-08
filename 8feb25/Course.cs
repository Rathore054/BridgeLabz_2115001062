using System;

class Course
{
    public string CourseName;
    public int Duration;

    public void DisplayInfo()
    {
        Console.WriteLine("Course Name: " + CourseName);
        Console.WriteLine("Duration: " + Duration + " weeks");
    }
}

class OnlineCourse : Course
{
    public string Platform;
    public bool IsRecorded;

    public new void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Platform: " + Platform);
        Console.WriteLine("Is Recorded: " + (IsRecorded ? "Yes" : "No"));
    }
}

class PaidOnlineCourse : OnlineCourse
{
    public double Fee;
    public double Discount;

    public new void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Fee: " + Fee);
        Console.WriteLine("Discount: " + Discount + "%");
    }
}

class Program
{
    static void Main()
    {
        PaidOnlineCourse course = new PaidOnlineCourse();
        course.CourseName = "Advanced C#";
        course.Duration = 8;
        course.Platform = "Udemy";
        course.IsRecorded = true;
        course.Fee = 100;
        course.Discount = 20;

        course.DisplayInfo();
    }
}
