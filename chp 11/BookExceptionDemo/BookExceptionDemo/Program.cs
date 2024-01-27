using System;
using static System.Console;
using System.Globalization;

class BookExceptionDemo
{
    static void Main()
    {
        try
        {
            // Example usage:
            Book book1 = new Book("Sample", "Mama", 10.00, 100);
            WriteLine("");
        }
        catch (BookException ex)
        {
            WriteLine($"Error creating book: {ex.Message}");
        }
    }
}

class BookException : Exception
{
    public BookException(string message) : base(message)
    {
    }
}

class Book
{
    private string title;
    private string author;
    private double price;
    private int pages;

    public Book(string title, string author, double price, int pages)
    {
        this.title = title;
        this.author = author;
        this.price = price;
        this.pages = pages;

        // Check if the price to pages ratio is greater than 0.10 (10 cents per page)
        if ((price / pages) > 0.10)
        {
            // If the ratio is exceeded, throw a BookException with an error message
            throw new BookException("Price to pages ratio exceeds 10 cents per page.");
        }
    }
}