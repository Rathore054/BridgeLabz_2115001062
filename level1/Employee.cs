using System;

class Employee
{
    public string Name;
    public int Id;
    public double Salary;

    public Employee(string name, int id, double salary)
    {
        Name = name;
        Id = id;
        Salary = salary;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}, ID: {Id}, Salary: {Salary}");
    }
}

class Program1
{
    static void Main()
    {
        Employee emp = new Employee("John Doe", 101, 50000);
        emp.DisplayDetails();
    }
}