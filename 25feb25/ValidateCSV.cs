using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;


class using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;


class ValidateCSV
{
    static void Main()
    {
        string filePath = "contacts.csv";
        var emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        var phoneRegex = new Regex(@"^\d{10}$");


        foreach (var line in File.ReadLines(filePath).Skip(1))
        {
            var data = line.Split(',');
            if (!emailRegex.IsMatch(data[1]) || !phoneRegex.IsMatch(data[2]))
            {
                Console.WriteLine("Invalid record: " + line);
            }
        }
    }
}

{
    static void Main()
    {
        string filePath = "contacts.csv";
        var emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        var phoneRegex = new Regex(@"^\d{10}$");


        foreach (var line in File.ReadLines(filePath).Skip(1))
        {
            var data = line.Split(',');
            if (!emailRegex.IsMatch(data[1]) || !phoneRegex.IsMatch(data[2]))
            {
                Console.WriteLine("Invalid record: " + line);
            }
        }
    }
}
