using System;
namespace program
{
    class Book
    {
        int bookid;
        string title;
        string author;
        int price;

    public void getdata()
        {
            bookid = 123;
            title = "java";
            author = "vrushali";
            price = 200;

        }
        public void getdata(int bookid)
        {
            this.bookid = bookid;

        }
        public void getdata(int bookid,string title)
        {
            this.bookid = bookid;
            this.title = title;
        }
        public void getdata(int bookid,string title,string author,int price)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;
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
            b.getdata();
            b.display();
            Console.WriteLine("-------------------book 1 details ---------------------");
            Book b1 = new Book();
            b1.getdata(111,"csharp");
            b1.display();

            Console.WriteLine("-----------------------book 2 details ------------------");
            Book b2 = new Book();
            b2.getdata(112, "csharp");
            b2.display();

            Console.WriteLine("------------------------ book 3 details-------------------");
            Book b3 = new Book();
            b3.getdata(123, "csharp", "mayuri", 100);

        }
    }
}