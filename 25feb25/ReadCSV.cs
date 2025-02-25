using System;
using System.IO;


class ReadCSV
{
    static void Main()
    {
        string filePath = "students.csv";
        foreach (var line in File.ReadLines(filePath))
        {
            Console.WriteLine(line);
        }
    }
}
