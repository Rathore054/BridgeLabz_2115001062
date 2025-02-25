using System;
using System.Collections.Generic;
using System.IO;


class Student
{
    public string ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Marks { get; set; }
}


class ConvertCSVToObjects
{
    static void Main()
    {
        string filePath = "students.csv";
        List<Student> students = new List<Student>();


        foreach (var line in File.ReadLines(filePath).Skip(1))
        {
            var data = line.Split(',');
            students.Add(new Student { ID = data[0], Name = data[1], Age = int.Parse(data[2]), Marks = int.Parse(data[3]) });
        }


        foreach (var student in students)
        {
            Console.WriteLine($"{student.ID}, {student.Name}, {student.Age}, {student.Marks}");
        }
    }
}
