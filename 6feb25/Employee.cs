using System;
using System.Collections.Generic;

class Employee
{
    private string name;

    public Employee(string name)
    {
        this.name = name;
    }

    public override string ToString()
    {
        return "Employee: " + name;
    }
}

class Department
{
    private string name;
    private List<Employee> employees;

    public Department(string name)
    {
        this.name = name;
        employees = new List<Employee>();
    }

    public void AddEmployee(string employeeName)
    {
        employees.Add(new Employee(employeeName));
    }

    public override string ToString()
    {
        string employeeList = "";
        foreach (Employee emp in employees)
        {
            employeeList += emp.ToString() + ", ";
        }
        return "Department: " + name + ", Employees: [" + employeeList.TrimEnd(',', ' ') + "]";
    }
}

class Company
{
    private string name;
    private List<Department> departments;

    public Company(string name)
    {
        this.name = name;
        departments = new List<Department>();
    }

    public void AddDepartment(string departmentName)
    {
        departments.Add(new Department(departmentName));
    }

    public Department GetDepartment(string departmentName)
    {
        foreach (Department dept in departments)
        {
            if (dept.ToString().Contains(departmentName))
            {
                return dept;
            }
        }
        return null;
    }

    public override string ToString()
    {
        string departmentList = "";
        foreach (Department dept in departments)
        {
            departmentList += dept.ToString() + ", ";
        }
        return "Company: " + name + ", Departments: [" + departmentList.TrimEnd(',', ' ') + "]";
    }

    ~Company()
    {
        Console.WriteLine("Deleting Company: " + name + " and all its departments and employees");
        departments.Clear();
    }
}

class Program
{
    static void Main()
    {
        Company company = new Company("Capgemini");
        company.AddDepartment("IT");
        company.AddDepartment("HR");

        Department itDepartment = company.GetDepartment("IT");
        if (itDepartment != null)
        {
            itDepartment.AddEmployee("Udit");
            itDepartment.AddEmployee("Sujal");
        }

        Department hrDepartment = company.GetDepartment("HR");
        if (hrDepartment != null)
        {
            hrDepartment.AddEmployee("Shivansh");
        }

        Console.WriteLine(company);
    }
}
