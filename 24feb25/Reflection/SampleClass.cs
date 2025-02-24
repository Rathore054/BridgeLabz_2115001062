using System;
using System.Reflection;

class SampleClass
{
    public int Value;
    public SampleClass() { }
    public void Display() { Console.WriteLine("Hello!"); }
}

class ReflectionExample
{
    static void Main()
    {
        Console.Write("Enter class name: ");
        string className = Console.ReadLine();

        Type type = Type.GetType(className);
        if (type == null)
        {
            Console.WriteLine("Class not found.");
            return;
        }

        Console.WriteLine("Methods:");
        foreach (var method in type.GetMethods()) Console.WriteLine(method.Name);

        Console.WriteLine("Fields:");
        foreach (var field in type.GetFields()) Console.WriteLine(field.Name);

        Console.WriteLine("Constructors:");
        foreach (var ctor in type.GetConstructors()) Console.WriteLine(ctor);
    }
}
