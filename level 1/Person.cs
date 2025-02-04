using System;

class Person
{
    public string Name;
    public int Age;

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public Person(Person p)
    {
        Name = p.Name;
        Age = p.Age;
    }

    public void DisplayPerson()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }

    static void Main()
    {
        Person p1 = new Person("Alice", 25);
        Person p2 = new Person(p1);

        p1.DisplayPerson();
        p2.DisplayPerson();
    }
}