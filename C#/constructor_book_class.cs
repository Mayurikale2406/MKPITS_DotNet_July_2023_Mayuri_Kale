using System;
namespace program
{
    class Book
    {
        int bookid;
        string title, author;
        int price;

        public Book()
        {
            bookid = 1;
            title = "java";
            author = "Mayuri";
            price = 200;

        }
        public void display()
        {
            Console.WriteLine("bookid : " + bookid);
            Console.WriteLine("title : " + title);
            Console.WriteLine("author : " + author);
            Console.WriteLine("price : " + price);
        }
    }
    class program
    {
        static void Main()
        {
            Book b = new Book();
            b.display();
            Console.ReadKey();
        }
    }
}