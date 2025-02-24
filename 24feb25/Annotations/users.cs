using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Field)]
class JsonField : Attribute
{
    public string Name { get; }

    public JsonField(string name)
    {
        Name = name;
    }
}

class Users
{
    [JsonField("user_name")]
    public string Username;

    public Users(string username)
    {
        Username = username;
    }

    public string ToJson()
    {
        return $"{{ \"{typeof(User).GetField("Username").GetCustomAttribute<JsonField>().Name}\": \"{Username}\" }}";
    }

    static void Main()
    {
        User user = new User("Alice");
        Console.WriteLine(user.ToJson());
    }
}
