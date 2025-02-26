using System;
using System.Collections.Generic;
using Newtonsoft.Json;

class ObjectListToJson
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    static void Main()
    {
        List<Person> people = new List<Person>
        {
            new Person { Name = "Udit", Age = 22 },
            new Person { Name = "Shivansh", Age = 21 }
        };

        string json = JsonConvert.SerializeObject(people, Formatting.Indented);
        Console.WriteLine(json);
    }
}
