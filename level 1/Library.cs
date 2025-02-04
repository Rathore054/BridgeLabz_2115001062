using System;
public class Library { 
    public static string LibraryName="GLA Library";
    private readonly int ISBN;
    public string Title;
    public string Author;
    public static void DisplayLibraryName() {
        Console.WriteLine("Library name :"+LibraryName);
    }
    public Library(string title, string author, int isbn) { 
    this.Title = title;
        this.Author = author;
        this.ISBN = isbn;
    }
   public void display() { 
     if (this is Library) {
     Console.WriteLine("Title :" + Title);
     Console.WriteLine("Author :" + Author);
     Console.WriteLine("ISBN :" + ISBN);
 }
    }
	
    static void Main(String[] args)
    {
        Library book = new Library("English","shivansh",200);
        Library book2 = new Library("maths", "udit", 324);
        book.display();
        book2.display();
        Library.DisplayLibraryName();
    }

}
