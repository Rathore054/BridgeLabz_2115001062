using System;
using System.Collections.Generic;

abstract class Employee
{
    protected int employeeId;
    protected string name;
    protected double baseSalary;

    public Employee(int employeeId, string name, double baseSalary)
    {
        this.employeeId = employeeId;
        this.name = name;
        this.baseSalary = baseSalary;
    }

    public abstract double CalculateSalary();

    public void DisplayDetails()
    {
        Console.WriteLine("ID: " + employeeId);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Salary: " + CalculateSalary());
    }
}

class FullTimeEmployee : Employee
{
    private double bonus;

    public FullTimeEmployee(int employeeId, string name, double baseSalary, double bonus)
        : base(employeeId, name, baseSalary)
    {
        this.bonus = bonus;
    }

    public override double CalculateSalary()
    {
        return baseSalary + bonus;
    }
}

class PartTimeEmployee : Employee
{
    private int workHours;
    private double hourlyRate;

    public PartTimeEmployee(int employeeId, string name, double hourlyRate, int workHours)
        : base(employeeId, name, 0)
    {
        this.workHours = workHours;
        this.hourlyRate = hourlyRate;
    }

    public override double CalculateSalary()
    {
        return workHours * hourlyRate;
    }
}

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>();
        employees.Add(new FullTimeEmployee(1, "John", 5000, 1000));
        employees.Add(new PartTimeEmployee(2, "Alice", 20, 100));

        foreach (Employee emp in employees)
        {
            emp.DisplayDetails();
            Console.WriteLine();
        }
    }
}
