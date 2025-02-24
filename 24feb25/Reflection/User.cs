using System;
using System.Collections.Generic;
using System.Reflection;

class User
{
    public string Name;
    public int Age;
}

class ObjectMapper
{
    public static T ToObject<T>(Dictionary<string, object> properties) where T : new()
    {
        T obj = new T();
        Type type = typeof(T);

        foreach (var prop in properties)
        {
            FieldInfo field = type.GetField(prop.Key);
            if (field != null) field.SetValue(obj, prop.Value);
        }

        return obj;
    }

    static void Main()
    {
        Dictionary<string, object> data = new Dictionary<string, object> { { "Name", "Alice" }, { "Age", 25 } };
        User user = ToObject<User>(data);
        Console.WriteLine($"{user.Name}, {user.Age}");
    }
}
