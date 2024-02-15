namespace Evaluation.Objects;

public class Book
{
    public string Title { get; set; }
    
    public bool EBook { get; set; }
    public string ISBN { get; set; }
    public Author Author { get; set; }
    public Publisher Publisher { get; set; }
    public int YearPublished { get; set; }
    public List<string> Genres { get; set; }
    public int PageCount { get; set; }
    public int AvailableCopies { get; set; }
    public double BorrowRate { get; set; } // Assuming this is a monetary value representing the cost to borrow
    public string ShelfLocation { get; set; }
    
    public Book(string title, bool eBook, string isbn, Author author, Publisher publisher, int yearPublished,
        List<string> genres, int pageCount, int availableCopies, double borrowRate, string shelfLocation)
    {
        Title = title;
        EBook = eBook;
        ISBN = isbn;
        Author = author;
        Publisher = publisher;
        YearPublished = yearPublished;
        Genres = genres;
        PageCount = pageCount;
        AvailableCopies = availableCopies;
        BorrowRate = borrowRate;
        ShelfLocation = shelfLocation;
    }
}

