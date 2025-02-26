using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;
using Newtonsoft.Json;

class CsvToJsonConverter
{
    static void Main()
    {
        using (var reader = new StreamReader("data.csv"))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            var records = csv.GetRecords<dynamic>();
            string json = JsonConvert.SerializeObject(records, Formatting.Indented);
            Console.WriteLine(json);
        }
    }
}
