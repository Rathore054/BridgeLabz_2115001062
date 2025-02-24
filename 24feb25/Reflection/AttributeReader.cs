using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Class)]
class Author : Attribute
{
    public string Name;
    public Author(string name) => Name = name;
}

[Author("John Doe")]
class SampleCode { }

class AttributeReader
{
    static void Main()
    {
        Type type = typeof(SampleCode);
        Author attr = (Author)Attribute.GetCustomAttribute(type, typeof(Author));
        Console.WriteLine("Author: " + attr.Name);
    }
}
