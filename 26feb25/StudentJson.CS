using System;
using Newtonsoft.Json;

class StudentJson
{
    static void Main()
    {
        var students = new[]
        {
            new { name = "Udit", age = 22, subjects = new string[] { "Math", "Science", "History" } },
            new { name = "Shivansh", age = 21, subjects = new string[] { "English", "Physics", "Computer Science" } }
        };

        string json = JsonConvert.SerializeObject(students, Formatting.Indented);
        Console.WriteLine(json);
    }
}
