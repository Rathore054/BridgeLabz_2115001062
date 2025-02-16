using System;
using System.IO;

class ReadFileLineByLine
{
    static void Main()
    {
        string path = "example.txt";
        using (StreamReader sr = new StreamReader(path))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}
