using System;
using System.IO;

class readlargefile
{
    static void Main()
    {
        try
        {
            using (StreamReader reader = new StreamReader("largefile.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains("error", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine(line);
                    }
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("IOException: " + ex.Message);
        }
    }
}
