

using System;
using System.IO;


class CountCSVRows
{
    static void Main()
    {
        string filePath = "employees.csv";
        int count = File.ReadAllLines(filePath).Length - 1;
        Console.WriteLine("Total Records: " + count);
    }
}
