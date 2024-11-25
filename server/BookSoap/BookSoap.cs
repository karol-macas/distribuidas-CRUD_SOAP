
using System;
using System.Collections.Generic;
using System.Linq;

public class BookSoap : IBookSoap
{
    static readonly private List<Book> _books = new List<Book>();

    private int GetMaxId()
    {
        if (_books.Count == 0) return 0;

        return _books.Max(book => book.Id);
    }

    public Book CreateBook(BookDTO newBook)
    {

        var book = new Book
        {
            Id = GetMaxId() + 1,
            Title = newBook.Title,
            Author = newBook.Author,
            Year = newBook.Year
        };

        _books.Add(book);

        return book;
    }

    public Book DeleteBook(int id)
    {
        var matchedBook = GetBook(id);

        _books.RemoveAll(book => book.Id == id);

        return matchedBook;
    }

    public Book GetBook(int id)
    {
        return _books.FirstOrDefault(book => book.Id == id);
    }

    public List<Book> GetBooks()
    {
        return _books;
    }

    public Book UpdateBook(Book updatedBook)
    {
        var matchedBook = GetBook(updatedBook.Id) ?? throw new Exception("Book Id cannot be find");

        matchedBook.Title = updatedBook.Title;
        matchedBook.Author = updatedBook.Author;
        matchedBook.Year = updatedBook.Year;

        return matchedBook;
    }
}