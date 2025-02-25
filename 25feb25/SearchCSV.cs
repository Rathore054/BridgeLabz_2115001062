using System;
using System.IO;
using System.Linq;


class SearchCSV
{
    static void Main()
    {
        string filePath = "employees.csv";
        Console.Write("Enter Employee Name: ");
        string searchName = Console.ReadLine();
        var line = File.ReadLines(filePath).Skip(1).FirstOrDefault(l => l.Split(',')[1] == searchName);
        if (line != null)
        {
            var data = line.Split(',');
            Console.WriteLine("Department: " + data[2] + ", Salary: " + data[3]);
        }
        else
        {
            Console.WriteLine("Employee not found.");
        }
    }
}
