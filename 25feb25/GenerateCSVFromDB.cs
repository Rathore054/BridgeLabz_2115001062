using System;
using System.Data.SqlClient;
using System.IO;


class GenerateCSVFromDB
{
    static void Main()
    {
        string connectionString = "your_connection_string";
        string query = "SELECT EmployeeID, Name, Department, Salary FROM Employees";
        string filePath = "employees_report.csv";


        using (var conn = new SqlConnection(connectionString))
        {
            conn.Open();
            using (var cmd = new SqlCommand(query, conn))
            using (var reader = cmd.ExecuteReader())
            using (var writer = new StreamWriter(filePath))
            {
                writer.WriteLine("EmployeeID,Name,Department,Salary");
                while (reader.Read())
                {
                    writer.WriteLine($"{reader[0]},{reader[1]},{reader[2]},{reader[3]}");
                }
            }
        }


        Console.WriteLine("CSV report generated successfully.");
    }
}
