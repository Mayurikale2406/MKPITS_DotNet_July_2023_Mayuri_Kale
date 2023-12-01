//Library Book Class: Implement a LibraryBook class with properties for Title, Author,
//and IsAvailable (a boolean flag indicating whether the book is available for borrowing).
//Create an array of LibraryBook objects to represent books in a library.
//Write a program that lists the available books.

using System;
namespace program
{
    class LibraryBook
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Book { get; set;}

        public void getdata(string title,string author,string book)
        {
            this.Title = title;
            this.Author = author;
            this.Book = book;
        }
        class program
        {
            LibraryBook lb = new LibraryBook();


        }
    }
}