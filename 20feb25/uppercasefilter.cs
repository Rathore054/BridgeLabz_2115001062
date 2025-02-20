using System;
using System.IO;

class uppercasefilter
{
    static void Main()
    {
        try
        {
            using (StreamReader reader = new StreamReader("source.txt"))
            using (StreamWriter writer = new StreamWriter("destination.txt"))
            using (BufferedStream bufferedStream = new BufferedStream(new FileStream("destination.txt", FileMode.Create)))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    writer.WriteLine(line.ToLower());
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("IOException: " + ex.Message);
        }
    }
}
