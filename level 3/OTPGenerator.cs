using System;

public class OTPGenerator
{
    public static void Main()
    {
        for (int i = 0; i < 10; i++)
            Console.WriteLine(GenerateOTP());
    }

    public static int GenerateOTP() => new Random().Next(100000, 1000000);
}
