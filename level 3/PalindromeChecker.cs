using System;

class PalindromeChecker
{
    static bool IsPalindrome(string str)
    {
        int left = 0, right = str.Length - 1;
        while (left < right)
        {
            if (str[left] != str[right])
                return false;
            left++;
            right--;
        }
        return true;
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        Console.WriteLine(IsPalindrome(input) ? "Palindrome" : "Not a Palindrome");
    }
}
