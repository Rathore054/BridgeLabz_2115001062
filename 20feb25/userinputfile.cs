using System;
using System.IO;

class userinputfile
{
    static void Main()
    {
        try
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter your favorite programming language: ");
            string language = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter("userinfo.txt"))
            {
                writer.WriteLine("Name: " + name);
                writer.WriteLine("Age: " + age);
                writer.WriteLine("Favorite Language: " + language);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
