using System;
using System.Reflection;

class Student
{
    public Student() { Console.WriteLine("Student instance created!"); }
}

class DynamicCreation
{
    static void Main()
    {
        Type type = typeof(Student);
        object obj = Activator.CreateInstance(type);
    }
}
