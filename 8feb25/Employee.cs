using System;

class Employee
{
    public string Name;
    public int Id;
    public double Salary;

    public void DisplayDetails()
    {
        Console.WriteLine("Employee Name: " + Name);
        Console.WriteLine("Employee ID: " + Id);
        Console.WriteLine("Salary: " + Salary);
    }
}

class Manager : Employee
{
    public int TeamSize;

    public new void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Team Size: " + TeamSize);
    }
}

class Developer : Employee
{
    public string ProgrammingLanguage;

    public new void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Programming Language: " + ProgrammingLanguage);
    }
}

class Intern : Employee
{
    public string InternshipDuration;

    public new void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Internship Duration: " + InternshipDuration);
    }
}

class Program
{
    static void Main()
    {
        Employee emp1 = new Manager { Name = "Alice", Id = 101, Salary = 50000, TeamSize = 5 };
        Employee emp2 = new Developer { Name = "Bob", Id = 102, Salary = 60000, ProgrammingLanguage = "C#" };
        Employee emp3 = new Intern { Name = "Charlie", Id = 103, Salary = 20000, InternshipDuration = "6 Months" };

        emp1.DisplayDetails();
        Console.WriteLine();
        emp2.DisplayDetails();
        Console.WriteLine();
        emp3.DisplayDetails();
    }
}
