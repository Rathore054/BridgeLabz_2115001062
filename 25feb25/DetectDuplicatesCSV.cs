using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


class DetectDuplicatesCSV
{
    static void Main()
    {
        string filePath = "students.csv";
        var ids = new HashSet<string>();
        var duplicates = new List<string>();


        foreach (var line in File.ReadLines(filePath).Skip(1))
        {
            var id = line.Split(',')[0];
            if (!ids.Add(id))
            {
                duplicates.Add(line);
            }
        }


        foreach (var dup in duplicates)
        {
            Console.WriteLine("Duplicate: " + dup);
        }
    }
}
