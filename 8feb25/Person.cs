using System;

class Person
{
    public string Name;
    public int Age;

    public void DisplayInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }
}

class Teacher : Person
{
    public string Subject;

    public new void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Subject: " + Subject);
    }
}

class Student : Person
{
    public string Grade;

    public new void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Grade: " + Grade);
    }
}

class Staff : Person
{
    public string Position;

    public new void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Position: " + Position);
    }
}

class Program
{
    static void Main()
    {
        Teacher teacher = new Teacher();
        teacher.Name = "Alice";
        teacher.Age = 40;
        teacher.Subject = "Mathematics";

        teacher.DisplayInfo();
    }
}
