using System;

class CompareStrings
{
    static void Main()
    {
        Console.Write("Enter first string: ");
        string str1 = Console.ReadLine();
        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine();

        int result = 0;
        int len = Math.Min(str1.Length, str2.Length);

        for (int i = 0; i < len; i++)
        {
            if (str1[i] != str2[i])
            {
                result = str1[i] - str2[i];
                break;
            }
        }

        if (result == 0)
            result = str1.Length - str2.Length;

        Console.WriteLine(result < 0 ? $"{str1} comes before {str2}" : $"{str2} comes before {str1}");
    }
}
