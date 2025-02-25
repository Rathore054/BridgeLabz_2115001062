using System;
using System.IO;


class ReadLargeCSV
{
    static void Main()
    {
        string filePath = "largefile.csv";
        int batchSize = 100, count = 0;


        using (var reader = new StreamReader(filePath))
        {
            reader.ReadLine();
            while (!reader.EndOfStream)
            {
                for (int i = 0; i < batchSize && !reader.EndOfStream; i++)
                {
                    reader.ReadLine();
                    count++;
                }
                Console.WriteLine($"Processed: {count} records");
            }
        }
    }
}
