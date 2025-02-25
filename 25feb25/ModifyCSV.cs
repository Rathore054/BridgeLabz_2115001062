using System;
using System.IO;
using System.Linq;


class ModifyCSV
{
    static void Main()
    {
        string filePath = "employees.csv";
        var lines = File.ReadAllLines(filePath);
        for (int i = 1; i < lines.Length; i++)
        {
            var data = lines[i].Split(',');
            if (data[2] == "IT")
            {
                data[3] = (int.Parse(data[3]) * 1.1).ToString();
                lines[i] = string.Join(",", data);
            }
        }
        File.WriteAllLines("updated_employees.csv", lines);
        Console.WriteLine("Salaries updated.");
    }
}
