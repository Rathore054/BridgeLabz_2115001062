using System;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System.Collections.Generic;

class ValidateJsonSchema
{
    static void Main()
    {
        string json = "{ \"name\": \"Udit\", \"email\": \"udit@example.com\" }";
        string schemaJson = "{ \"type\": \"object\", \"properties\": { \"name\": { \"type\": \"string\" }, \"email\": { \"type\": \"string\", \"format\": \"email\" } }, \"required\": [\"name\", \"email\"] }";

        JSchema schema = JSchema.Parse(schemaJson);
        JObject jsonObj = JObject.Parse(json);

        IList<string> errors;
        bool isValid = jsonObj.IsValid(schema, out errors);

        Console.WriteLine(isValid ? "Valid JSON" : "Invalid JSON: " + string.Join(", ", errors));
    }
}
