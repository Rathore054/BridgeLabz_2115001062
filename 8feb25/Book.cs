using System;
class Book
{
    public string Title;
    public int PublicationYear;

    public void DisplayInfo()
    {
        Console.WriteLine("Book Title: " + Title);
        Console.WriteLine("Publication Year: " + PublicationYear);
    }
}

class Author : Book
{
    public string Name;
    public string Bio;

    public new void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Author Name: " + Name);
        Console.WriteLine("Bio: " + Bio);
    }
}

class Program
{
    static void Main()
    {
        Author author = new Author();
        author.Title = "C# Programming";
        author.PublicationYear = 2021;
        author.Name = "John Doe";
        author.Bio = "Expert in C# development.";

        author.DisplayInfo();
    }
}
