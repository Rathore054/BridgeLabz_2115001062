using System;
using System.IO;
using System.Linq;
using Newtonsoft.Json.Linq;

class FilterJsonByAge
{
    static void Main()
    {
        string json = File.ReadAllText("users.json");
        JArray users = JArray.Parse(json);

        var filteredUsers = users.Where(u => (int)u["age"] > 25).ToList();
        Console.WriteLine(JArray.FromObject(filteredUsers).ToString());
    }
}
