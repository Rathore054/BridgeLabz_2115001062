using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


class MergeCSV
{
    static void Main()
    {
        var file1 = File.ReadAllLines("students1.csv").Skip(1);
        var file2 = File.ReadAllLines("students2.csv").Skip(1);
        Dictionary<string, string> data = new Dictionary<string, string>();


        foreach (var line in file1)
        {
            var parts = line.Split(',');
            data[parts[0]] = line;
        }


        foreach (var line in file2)
        {
            var parts = line.Split(',');
            if (data.ContainsKey(parts[0]))
            {
                data[parts[0]] += "," + string.Join(",", parts.Skip(1));
            }
        }


        File.WriteAllLines("merged_students.csv", new[] { "ID,Name,Age,Marks,Grade" }.Concat(data.Values));
        Console.WriteLine("CSV files merged successfully.");
    }
}
