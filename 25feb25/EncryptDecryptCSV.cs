using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

class EncryptDecryptCSV
{
    private static readonly string key = "0123456789abcdef";

    static void Main()
    {
        EncryptCSV("employees.csv", "encrypted_employees.csv");
        DecryptCSV("encrypted_employees.csv", "decrypted_employees.csv");
    }

    static string Encrypt(string data)
    {
        using (var aes = Aes.Create())
        {
            aes.Key = Encoding.UTF8.GetBytes(key);
            aes.IV = new byte[16];
            using (var encryptor = aes.CreateEncryptor())
            {
                byte[] buffer = Encoding.UTF8.GetBytes(data);
                return Convert.ToBase64String(encryptor.TransformFinalBlock(buffer, 0, buffer.Length));
            }
        }
    }

    static string Decrypt(string data)
    {
        using (var aes = Aes.Create())
        {
            aes.Key = Encoding.UTF8.GetBytes(key);
            aes.IV = new byte[16];
            using (var decryptor = aes.CreateDecryptor())
            {
                byte[] buffer = Convert.FromBase64String(data);
                return Encoding.UTF8.GetString(decryptor.TransformFinalBlock(buffer, 0, buffer.Length));
            }
        }
    }

    static void EncryptCSV(string inputFile, string outputFile)
    {
        var lines = File.ReadAllLines(inputFile);
        using (var writer = new StreamWriter(outputFile))
        {
            writer.WriteLine(lines[0]);
            foreach (var line in lines.Skip(1))
            {
                var data = line.Split(',');
                data[3] = Encrypt(data[3]);
                writer.WriteLine(string.Join(",", data));
            }
        }
        Console.WriteLine("CSV data encrypted.");
    }

    static void DecryptCSV(string inputFile, string outputFile)
    {
        var lines = File.ReadAllLines(inputFile);
        using (var writer = new StreamWriter(outputFile))
        {
            writer.WriteLine(lines[0]);
            foreach (var line in lines.Skip(1))
            {
                var data = line.Split(',');
                data[3] = Decrypt(data[3]);
                writer.WriteLine(string.Join(",", data));
            }
        }
        Console.WriteLine("CSV data decrypted.");
    }
}
