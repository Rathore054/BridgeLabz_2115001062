using System;
class YoungestAndTallest
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Amar's age: ");
        int amarAge = int.Parse(Console.ReadLine());
        Console.Write("Enter Amar's height in cm: ");
        int amarHeight = int.Parse(Console.ReadLine());
        Console.Write("Enter Akbar's age: ");
        int akbarAge = int.Parse(Console.ReadLine());
        Console.Write("Enter Akbar's height in cm: ");
        int akbarHeight = int.Parse(Console.ReadLine());
        Console.Write("Enter Anthony's age: ");
        int anthonyAge = int.Parse(Console.ReadLine());
        Console.Write("Enter Anthony's height in cm: ");
        int anthonyHeight = int.Parse(Console.ReadLine());
        int youngestAge = Math.Min(amarAge, Math.Min(akbarAge, anthonyAge));
        int tallestHeight = Math.Max(amarHeight, Math.Max(akbarHeight, anthonyHeight));
        string youngestFriend = youngestAge == amarAge ? "Amar" : youngestAge == akbarAge ? "Akbar" : "Anthony";
        string tallestFriend = tallestHeight == amarHeight ? "Amar" : tallestHeight == akbarHeight ? "Akbar" : "Anthony";
        Console.WriteLine($"\nThe youngest friend is {youngestFriend} with age {youngestAge} years.");
        Console.WriteLine($"The tallest friend is {tallestFriend} with height {tallestHeight} cm.");
    }
}
