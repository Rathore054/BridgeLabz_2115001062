using System;
using System.IO;

class imagebytearray
{
    static void Main()
    {
        try
        {
            byte[] imageBytes = File.ReadAllBytes("input.jpg");

            using (MemoryStream memoryStream = new MemoryStream(imageBytes))
            {
                using (FileStream fileStream = new FileStream("output.jpg", FileMode.Create))
                {
                    memoryStream.CopyTo(fileStream);
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("IOException: " + ex.Message);
        }
    }
}
