using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Linq;


class JsonCsvConverter
{
    static void Main()
    {
        ConvertJsonToCsv("students.json", "students.csv");
        ConvertCsvToJson("students.csv", "students.json");
    }


    static void ConvertJsonToCsv(string jsonFile, string csvFile)
    {
        var jsonData = File.ReadAllText(jsonFile);
        var students = JsonSerializer.Deserialize<List<Dictionary<string, string>>>(jsonData);
        var headers = students.First().Keys;


        using (var writer = new StreamWriter(csvFile))
        {
            writer.WriteLine(string.Join(",", headers));
            foreach (var student in students)
            {
                writer.WriteLine(string.Join(",", student.Values));
            }
        }


        Console.WriteLine("JSON converted to CSV.");
    }


    static void ConvertCsvToJson(string csvFile, string jsonFile)
    {
        var lines = File.ReadAllLines(csvFile);
        var headers = lines[0].Split(',');
        var data = lines.Skip(1).Select(line => line.Split(',')).Select(values =>
            headers.Zip(values, (header, value) => new { header, value }).ToDictionary(x => x.header, x => x.value)
        );


        File.WriteAllText(jsonFile, JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true }));
        Console.WriteLine("CSV converted to JSON.");
    }
}
