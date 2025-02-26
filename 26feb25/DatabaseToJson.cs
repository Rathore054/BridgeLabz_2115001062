using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using Newtonsoft.Json;

class DatabaseToJson
{
    static void Main()
    {
        string connectionString = "your_connection_string";
        string query = "SELECT EmployeeID, Name, Department, Salary FROM Employees";
        string jsonFile = "employees.json";

        List<Dictionary<string, object>> records = new List<Dictionary<string, object>>();

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Dictionary<string, object> record = new Dictionary<string, object>();
                    for (int i = 0; i < reader.FieldCount; i++)
                        record[reader.GetName(i)] = reader[i];
                    records.Add(record);
                }
            }
        }

        File.WriteAllText(jsonFile, JsonConvert.SerializeObject(records, Formatting.Indented));
        Console.WriteLine("JSON report generated.");
    }
}
