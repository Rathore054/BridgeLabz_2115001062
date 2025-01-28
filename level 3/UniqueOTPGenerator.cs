using System;
using System.Linq;

public class UniqueOTPGenerator
{
    public static void Main()
    {
        int[] otps = new int[10];
        Random random = new Random();

        for (int i = 0; i < otps.Length; i++)
            otps[i] = GenerateOTP(random);

        bool unique = otps.Distinct().Count() == otps.Length;
        Console.WriteLine("Unique OTPs: " + unique);
        Console.WriteLine(string.Join(", ", otps));
    }

    public static int GenerateOTP(Random random) => random.Next(100000, 1000000);
}
