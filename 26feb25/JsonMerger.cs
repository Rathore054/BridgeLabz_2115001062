using System;
using Newtonsoft.Json.Linq;

class JsonMerger
{
    static void Main()
    {
        string json1 = "{ \"name\": \"Udit\", \"age\": 22 }";
        string json2 = "{ \"email\": \"udit@example.com\", \"city\": \"Delhi\" }";

        JObject obj1 = JObject.Parse(json1);
        JObject obj2 = JObject.Parse(json2);

        obj1.Merge(obj2, new JsonMergeSettings { MergeArrayHandling = MergeArrayHandling.Union });

        Console.WriteLine(obj1.ToString());
    }
}
