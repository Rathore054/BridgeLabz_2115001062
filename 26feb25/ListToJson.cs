using System;
using System.Collections.Generic;
using Newtonsoft.Json;

class ListToJson
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    static void Main()
    {
        List<Person> people = new List<Person>();

        Person person1 = new Person();
        person1.Name = "Udit";
        person1.Age = 22;

        Person person2 = new Person();
        person2.Name = "Shivansh";
        person2.Age = 21;

        people.Add(person1);
        people.Add(person2);

        string json = JsonConvert.SerializeObject(people, Formatting.Indented);
        Console.WriteLine(json);
    }
}
