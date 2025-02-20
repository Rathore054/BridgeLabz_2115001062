using System;
using System.IO;
using System.Threading;

class pipestreamcommunication
{
    static void Main()
    {
        PipeStream pipe = new PipeStream(PipeDirection.InOut);

        Thread writerThread = new Thread(() =>
        {
            using (StreamWriter writer = new StreamWriter(pipe))
            {
                writer.WriteLine("Hello from the writer thread.");
                writer.Flush();
            }
        });

        Thread readerThread = new Thread(() =>
        {
            using (StreamReader reader = new StreamReader(pipe))
            {
                Console.WriteLine(reader.ReadLine());
            }
        });

        writerThread.Start();
        readerThread.Start();

        writerThread.Join();
        readerThread.Join();
    }
}
