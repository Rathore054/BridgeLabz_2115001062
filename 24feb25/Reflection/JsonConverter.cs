using System;
using System.Reflection;
using System.Text;

class User
{
    public string Name = "Alice";
    public int Age = 25;
}

class JsonConverter
{
    public static string ToJson(object obj)
    {
        Type type = obj.GetType();
        StringBuilder json = new StringBuilder("{");

        foreach (FieldInfo field in type.GetFields())
        {
            json.AppendFormat("\"{0}\": \"{1}\", ", field.Name, field.GetValue(obj));
        }

        json.Remove(json.Length - 2, 2).Append("}");
        return json.ToString();
    }

    static void Main()
    {
        User user = new User();
        Console.WriteLine(ToJson(user));
    }
}
