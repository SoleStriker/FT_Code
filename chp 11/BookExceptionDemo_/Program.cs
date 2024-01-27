using System;
using System.Globalization;

class BookException : Exception
{
    public BookException(string message) : base(message) { }
}

class Book
{
    private string title;
    private string author;
    private decimal price;
    private int pages;

    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public string Author
    {
        get { return author; }
        set { author = value; }
    }

    public decimal Price
    {
        get { return price; }
        set
        {
            if (value > 0)
            {
                decimal maxAllowedPrice = 0.10M * pages;
                if (value > maxAllowedPrice)
                {
                    string errorMessage = $"For {title}, ratio is invalid.\nPrice is {value.ToString("C", CultureInfo.GetCultureInfo("en-US"))} for {pages} pages.";
                    throw new BookException(errorMessage);
                }
                else
                {
                    price = value;
                }
            }
            else
            {
                throw new ArgumentException("Price must be greater than zero.");
            }
        }
    }

    public int Pages
    {
        get { return pages; }
        set
        {
            if (value > 0)
            {
                pages = value;
            }
            else
            {
                throw new ArgumentException("Number of pages must be greater than zero.");
            }
        }
    }
}

class BookExceptionDemo
{
    static void Main()
    {
        Book[] books = new Book[5];

        for (int i = 0; i < 5; i++)
        {
            Book book = new Book();

            Console.WriteLine($"Enter details for Book {i + 1}:");

            Console.Write("Title: ");
            book.Title = Console.ReadLine();

            Console.Write("Author: ");
            book.Author = Console.ReadLine();

            Console.Write("Number of Pages: ");
            try
            {
                book.Pages = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number of pages format. Setting pages to 1.");
                book.Pages = 1;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Invalid number of pages: {ex.Message}. Setting pages to 1.");
                book.Pages = 1;
            }

            Console.Write("Price: ");
            try
            {
                book.Price = decimal.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid price format. Setting price to maximum allowed.");
                book.Price = 0.10M * book.Pages;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Invalid price: {ex.Message}. Setting price to maximum allowed.");
                book.Price = 0.10M * book.Pages;
            }

            

            books[i] = book;
        }

        Console.WriteLine("\nEntered Book Records:");
        foreach (Book book in books)
        {
            Console.WriteLine($"Title: {book.Title}\nAuthor: {book.Author}\nPrice: {book.Price.ToString("C", CultureInfo.GetCultureInfo("en-US"))}\nPages: {book.Pages}\n");
        }
    }
}
