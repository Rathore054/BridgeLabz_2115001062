

using System;
using System.IO;
using System.Linq;


class FilterCSV
{
    static void Main()
    {
        string filePath = "students.csv";
        var lines = File.ReadAllLines(filePath).Skip(1);
        foreach (var line in lines)
        {
            var data = line.Split(',');
            if (int.Parse(data[3]) > 80)
            {
                Console.WriteLine(line);
            }
        }
    }
}
