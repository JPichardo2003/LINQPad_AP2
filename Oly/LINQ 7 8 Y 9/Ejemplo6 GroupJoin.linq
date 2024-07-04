<Query Kind="Program" />

using System;
using System.Collections.Generic;
using System.Linq;

public class Author
{
    public int AuthorID { get; set; }
    public string AuthorName { get; set; }
}

public class Book
{
    public int BookID { get; set; }
    public string BookTitle { get; set; }
    public int AuthorID { get; set; }
}

class Program
{
    static void Main()
    {
        IList<Author> authorList = new List<Author>() {
            new Author() { AuthorID = 1, AuthorName = "George Orwell" },
            new Author() { AuthorID = 2, AuthorName = "J.K. Rowling" },
            new Author() { AuthorID = 3, AuthorName = "J.R.R. Tolkien" }
        };

        IList<Book> bookList = new List<Book>() {
            new Book() { BookID = 1, BookTitle = "1984", AuthorID = 1 },
            new Book() { BookID = 2, BookTitle = "Animal Farm", AuthorID = 1 },
            new Book() { BookID = 3, BookTitle = "Harry Potter and the Sorcerer's Stone", AuthorID = 2 },
            new Book() { BookID = 4, BookTitle = "The Hobbit", AuthorID = 3 }
        };

        var groupJoinQuery = from author in authorList
                             join book in bookList
                             on author.AuthorID equals book.AuthorID
                             into bookGroup
                             select new
                             {
                                 AuthorName = author.AuthorName,
                                 Books = bookGroup
                             };

        foreach (var author in groupJoinQuery)
        {
            Console.WriteLine(author.AuthorName);
            foreach (var book in author.Books)
            {
                Console.WriteLine($"  {book.BookTitle}");
            }
        }
    }
}
