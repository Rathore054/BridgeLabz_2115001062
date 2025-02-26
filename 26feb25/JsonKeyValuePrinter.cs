using System;
using System.IO;
using Newtonsoft.Json.Linq;

class JsonKeyValuePrinter
{
    static void Main()
    {
        string json = File.ReadAllText("data.json");
        JObject jsonObject = JObject.Parse(json);

        foreach (var pair in jsonObject)
        {
            Console.WriteLine(pair.Key + ": " + pair.Value);
        }
    }
}
