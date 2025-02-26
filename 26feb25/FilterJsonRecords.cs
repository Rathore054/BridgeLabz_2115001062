using System;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

class FilterJsonRecords
{
    static void Main()
    {
        string json = File.ReadAllText("people.json");
        JArray people = JArray.Parse(json);

        var filtered = people.Where(p => (int)p["age"] > 25).ToList();
        string result = JsonConvert.SerializeObject(filtered, Formatting.Indented);
        Console.WriteLine(result);
    }
}
