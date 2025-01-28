using System;

public class FriendsDetails
{
    public static int FindYoungest(int[] ages)
    {
        int minAge = ages[0];
        foreach (int age in ages)
        {
            if (age < minAge) minAge = age;
        }
        return minAge;
    }

    public static int FindTallest(int[] heights)
    {
        int maxHeight = heights[0];
        foreach (int height in heights)
        {
            if (height > maxHeight) maxHeight = height;
        }
        return maxHeight;
    }

    public static void Main()
    {
        int[] ages = new int[3];
        int[] heights = new int[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Enter age of friend {i + 1}: ");
            ages[i] = int.Parse(Console.ReadLine());

            Console.Write($"Enter height (in cm) of friend {i + 1}: ");
            heights[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Youngest Age: " + FindYoungest(ages));
        Console.WriteLine("Tallest Height: " + FindTallest(heights));
    }
}
