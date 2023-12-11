//3 - Question: Implement a simple library management system in C#.
//Design classes for Book, Author, and Library.
//Each book should have properties like Title, ISBN, and a reference
//to an Author. The Library class should keep track of a collection of
//books. Implement methods for adding a book, removing a book,
//and displaying the list of books with their details.
//Ensure that the system handles the scenario where multiple books
//share the same title but have different ISBNs.
//Write a program to demonstrate the functionality of your library
//management system.
using System;
using System.Collections.Generic;
namespace program
{
    class Author
    {
        public string authorname { get; }

        public Author(string authorname)
        {
            this.authorname = authorname;
        }
    }
    class Book
    {
        public string title { get; }
        public string ISBN { get; }
        public string author { get; }
        public Book(string title,string ISBN,string author)
        {
            this.author = author;
            this.ISBN = ISBN;
            this.title = title;
        }
        public override string ToString()
        {
            return "Title :" + title + "ISBN No :" + ISBN + "Author Name :" + author;
        }
    }
    class library
    {
        private List<Book> books = new List<Book>();
        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine("Book added to the library : " + book);
        }
        public void RemoveBook(string isbn)
        {
            Book bookToRemove = null;
            foreach (var book in books)
            {
                if(book.ISBN == isbn )
                {
                    bookToRemove = null;

                }
                bookToRemove = book;
                break;
            }
            if(bookToRemove != null)
            {
                books.Remove(bookToRemove);
                Console.WriteLine("book removed from the library " + bookToRemove);

            }
            else
            {
                Console.WriteLine("book with ISBN " + isbn + "not found in the library");
            }
        }
        public void DisplayBooks()
        {
            Console.WriteLine("Book in the library");
            foreach(var book in books)
            {
                Console.WriteLine(book);
            }
            Console.WriteLine();
        }
        
        
    }
    class program
    {
        static void Main()
        {
            Author author1 = new Author("mayuri kale");
            Author author2 = new Author("vrushali mohite");
            Author author3 = new Author("sayali kapse");

            Book book1 = new Book("Introduction to C#", "123456",author1);
            Book book2 = new Book("Introduction to java", "456789",author2);
            Book book3 = new Book("Introduction to dotnet", "987678",author3);
            Book book4 = new Book("Advanced Java", "567890" , author2);

            library library = new library();
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);

            library.DisplayBooks();
            library.RemoveBook("987678");
            library.DisplayBooks();


            
        }
    }

}