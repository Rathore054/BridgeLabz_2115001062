using System;
class Student
{
    public static string UniversityName = "GLA University";
    private static int totalstudents = 0;
    public string Name;
    private readonly int RollNumber;
    public string Grade;
    public static void DisplayTotalStudents()
    {
        Console.WriteLine("Total Students :" + totalstudents);
    }
    public Student(string name, int rollNumber, string grade)
    {
        this.Name = name;
        this.RollNumber = rollNumber;
        this.Grade = grade;
        totalstudents++;    
    }
    public void Displaystudentdetails()
    {
        if (this is Student)
        {

            Console.WriteLine("University Name :" + UniversityName);
            Console.WriteLine("Student Name :" + Name);
            Console.WriteLine("Roll Number :" + RollNumber);
            Console.WriteLine("Grade :" + Grade);
        }
    }
    static void Main()
    {
        Student stu1 = new Student("Shivansh", 0001, "Btech");
        Student stu2 = new Student("Rajeev", 0002, "Btech");
        stu1.Displaystudentdetails();
        stu2.Displaystudentdetails();
        Student.DisplayTotalStudents();
    }
}
