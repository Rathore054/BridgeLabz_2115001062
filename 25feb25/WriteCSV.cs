

using System;
using System.IO;


class WriteCSV
{
    static void Main()
    {
        string filePath = "employees.csv";
        string[] data = {
            "ID,Name,Department,Salary",
            "1,John Doe,HR,50000",
            "2,Jane Smith,IT,60000",
            "3,Robert Brown,Finance,55000",
            "4,Emily Davis,Marketing,52000",
            "5,Michael Wilson,IT,62000"
        };
        File.WriteAllLines(filePath, data);
        Console.WriteLine("CSV file written successfully.");
    }
}
