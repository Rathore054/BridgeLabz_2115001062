using System;
using System.IO;
using System.Diagnostics;

class bufferedstreamcopy
{
    static void Main()
    {
        string sourceFile = "largefile.txt";
        string destFile = "copyfile.txt";

        Stopwatch stopwatch = new Stopwatch();

        stopwatch.Start();
        using (BufferedStream source = new BufferedStream(new FileStream(sourceFile, FileMode.Open)))
        using (BufferedStream dest = new BufferedStream(new FileStream(destFile, FileMode.Create)))
        {
            byte[] buffer = new byte[4096];
            int bytesRead;
            while ((bytesRead = source.Read(buffer, 0, buffer.Length)) > 0)
            {
                dest.Write(buffer, 0, bytesRead);
            }
        }
        stopwatch.Stop();
        Console.WriteLine("Buffered stream copy time: " + stopwatch.ElapsedMilliseconds + "ms");

        stopwatch.Restart();
        using (FileStream source = new FileStream(sourceFile, FileMode.Open))
        using (FileStream dest = new FileStream(destFile, FileMode.Create))
        {
            byte[] buffer = new byte[4096];
            int bytesRead;
            while ((bytesRead = source.Read(buffer, 0, buffer.Length)) > 0)
            {
                dest.Write(buffer, 0, bytesRead);
            }
        }
        stopwatch.Stop();
        Console.WriteLine("Unbuffered stream copy time: " + stopwatch.ElapsedMilliseconds + "ms");
    }
}
