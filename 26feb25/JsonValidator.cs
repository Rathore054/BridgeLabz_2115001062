using System;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System.Collections.Generic;

class JsonValidator
{
    static void Main()
    {
        string json = "{ \"name\": \"Shivansh\", \"age\": 21 }";
        string schemaJson = "{ \"type\": \"object\", \"properties\": { \"name\": { \"type\": \"string\" }, \"age\": { \"type\": \"integer\" } }, \"required\": [\"name\", \"age\"] }";

        JSchema schema = JSchema.Parse(schemaJson);
        JObject jsonObj = JObject.Parse(json);

        IList<string> errors;
        bool isValid = jsonObj.IsValid(schema, out errors);
        
        if (isValid)
            Console.WriteLine("Valid JSON");
        else
            Console.WriteLine("Invalid JSON: " + string.Join(", ", errors));
    }
}
