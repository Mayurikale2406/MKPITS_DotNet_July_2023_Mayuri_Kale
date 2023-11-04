using System;
namespace program
{
    class Book
    {
        int bookid;
        string title;
        string author;
        

    public Book()
        {
            bookid = 1;
            title = "dotnet";
            author = "mayuri";

        }
    public Book(Book b2)
        {
            bookid = b2.bookid;
            title = b2.title;
            author = b2.author;
        }
        public void display()
        {
            Console.WriteLine("book id : " + bookid);
            Console.WriteLine("title : " + title);
            Console.WriteLine("author : " + author);
        }
    }
    class program
    {
        static void Main()
        {
            Book book1 = new Book();
            Book book2 = new Book(book1);
            Console.WriteLine("book 1 details are : ");
            book1.display();
            Console.WriteLine("book 2 details are : ");
            book2.display();
            Console.ReadKey();
        }
    }
}