using System;
using System.Security.Cryptography.X509Certificates;

namespace program
{
    class Book
    {
        int bookid;
        string author;
        string title;
        int price;

        public Book()
        {
            Console.WriteLine("constructor with no paramter called");
            bookid = 123;
            author = "mayuri";
            title = "dotnet";
            price = 200;
        }
        public Book(int bookid, string author, string title, int price)
        {
            Console.WriteLine("constructor with paramter called : ");
            this.bookid = bookid;
            this.author = author;
            this.title = title;
            this.price = price;
        }
        public void display()
        {
            Console.WriteLine("bookid : " + bookid);
            Console.WriteLine("author : " + author);
            Console.WriteLine("title : " + title);
            Console.WriteLine("price : " + price);
        }
    }
    class program
    {
        static void Main()
        {
            Book b = new Book(22, "mayuri", "dotnet", 200);
            b.display();
            Console.ReadKey();
        }
    }
}