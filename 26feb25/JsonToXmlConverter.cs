using System;
using System.Xml;
using Newtonsoft.Json;

class JsonToXmlConverter
{
    static void Main()
    {
        string json = "{ \"name\": \"Udit\", \"age\": 22 }";
        XmlDocument doc = JsonConvert.DeserializeXmlNode(json, "Root");
        Console.WriteLine(doc.OuterXml);
    }
}
