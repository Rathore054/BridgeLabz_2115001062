using System;
using System.IO;

class ConvertByteStreamToCharacterStream
{
    static void Main()
    {
        string path = "example.bin";  // Specify the binary file path
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
