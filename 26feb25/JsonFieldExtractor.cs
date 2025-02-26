using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

class JsonFieldExtractor
{
    static void Main()
    {
        string json = File.ReadAllText("users.json");
        JArray users = JArray.Parse(json);

        foreach (var user in users)
        {
            string name = user["name"].ToString();
            string email = user["email"].ToString();
            Console.WriteLine("Name: " + name + ", Email: " + email);
        }
    }
}
