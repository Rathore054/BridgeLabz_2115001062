using System;
using System.IO;
using System.Diagnostics;

class FileReadingComparison
{
    static void ReadUsingStreamReader(string filePath)
    {
        Stopwatch sw = Stopwatch.StartNew();
        using (StreamReader sr = new StreamReader(filePath))
        {
            while (sr.Read() != -1) { } 
        }
        sw.Stop();
        Console.WriteLine($"StreamReader Time: {sw.ElapsedMilliseconds}ms");
    }

    static void ReadUsingFileStream(string filePath)
    {
        Stopwatch sw = Stopwatch.StartNew();
        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        {
            byte[] buffer = new byte[4096]; 
            while (fs.Read(buffer, 0, buffer.Length) > 0) { }
        }
        sw.Stop();
        Console.WriteLine($"FileStream Time: {sw.ElapsedMilliseconds}ms");
    }

    public static void Main()
    {
        string filePath = "largefile.txt"; 

        Console.WriteLine("Reading with StreamReader...");
        ReadUsingStreamReader(filePath);

        Console.WriteLine("Reading with FileStream...");
        ReadUsingFileStream(filePath);
    }
}
