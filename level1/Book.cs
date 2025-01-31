using System;

class Book
{
    public string Title;
    public string Author;
    public double Price;

    public Book(string title, string author, double price)
    {
        Title = title;
        Author = author;
        Price = price;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, Price: {Price}");
    }
}

class Program3
{
    static void Main()
    {
        Book book = new Book("C# Programming", "Author Name", 299.99);
        book.DisplayDetails();
    }
}
