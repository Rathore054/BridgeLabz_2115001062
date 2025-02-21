using System;
using System.IO;

class fileNotFoundException
{
    static void Main()
    {
        try
        {
            using (StreamReader reader = new StreamReader("data.txt"))
            {
                Console.WriteLine(reader.ReadToEnd());
            }
        }
        catch (IOException)
        {
            Console.WriteLine("File not found");
        }
    }
}
