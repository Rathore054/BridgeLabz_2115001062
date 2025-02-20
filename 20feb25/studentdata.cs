using System;
using System.IO;

class studentdata
{
    static void Main()
    {
        try
        {
            using (BinaryWriter writer = new BinaryWriter(new FileStream("studentdata.dat", FileMode.Create)))
            {
                writer.Write(101);
                writer.Write("John Doe");
                writer.Write(3.75f);
            }

            using (BinaryReader reader = new BinaryReader(new FileStream("studentdata.dat", FileMode.Open)))
            {
                int rollNo = reader.ReadInt32();
                string name = reader.ReadString();
                float gpa = reader.ReadSingle();

                Console.WriteLine("Roll No: " + rollNo + ", Name: " + name + ", GPA: " + gpa);
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("IOException: " + ex.Message);
        }
    }
}
