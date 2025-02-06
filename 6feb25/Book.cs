using System;
using System.Collections.Generic;

class Book
{
    public string Title ;
    public string Author ;
}

class Library
{
    public List<Book> Books  = new List<Book>();
}

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book { Title = "2004", Author = "Sujal" };
        Book book2 = new Book { Title = "2002", Author = "Udit" };

        Library library1 = new Library();
        library1.Books.Add(book1);
        library1.Books.Add(book2);

        Book book3 = new Book { Title = "Hello World", Author = "Shivansh" };
        Library library2 = new Library();
        library2.Books.Add(book3);

        Console.WriteLine("Library 1 Books:");
        foreach (var book in library1.Books)
        {
            Console.WriteLine(book.Title + " by " + book.Author);
        }

        Console.WriteLine("Library 2 Books:");
        foreach (var book in library2.Books)
        {
            Console.WriteLine(book.Title + " by " + book.Author);
        }
    }
}

