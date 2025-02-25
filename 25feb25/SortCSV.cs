using System;
using System.IO;
using System.Linq;


class SortCSV
{
    static void Main()
    {
        string filePath = "employees.csv";
        var lines = File.ReadAllLines(filePath);
        var sorted = lines.Skip(1).OrderByDescending(l => int.Parse(l.Split(',')[3])).Take(5);
        Console.WriteLine(lines[0]);
        foreach (var line in sorted)
        {
            Console.WriteLine(line);
        }
    }
}
