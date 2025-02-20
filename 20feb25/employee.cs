using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

class employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public decimal Salary { get; set; }
}

class serializeemployee
{
    static void Main()
    {
        try
        {
            List<employee> employees = new List<employee>
            {
                new employee { Id = 1, Name = "John", Department = "HR", Salary = 50000 },
                new employee { Id = 2, Name = "Jane", Department = "IT", Salary = 60000 }
            };

            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream("employees.dat", FileMode.Create, FileAccess.Write))
            {
                formatter.Serialize(stream, employees);
            }

            using (Stream stream = new FileStream("employees.dat", FileMode.Open, FileAccess.Read))
            {
                List<employee> deserializedEmployees = (List<employee>)formatter.Deserialize(stream);
                foreach (var emp in deserializedEmployees)
                {
                    Console.WriteLine(emp.Id + ", " + emp.Name + ", " + emp.Department + ", " + emp.Salary);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
