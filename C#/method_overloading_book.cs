using System;
using System.Diagnostics;

namespace program
{
    class Book
    {
        int bookid;
        string title, author;
        int price;
    public void getdata()
        {
            bookid = 123;
            title = "java";
            author = "vrushali";
            price = 200;
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
            Console.WriteLine("bookid :" + bookid);
            Console.WriteLine("book title : " + title);
            Console.WriteLine("book author : " + author);
            Console.WriteLine("book price : " + price);
        }
        class program
        {
            static void Main()
            {
                Book b = new Book();
                b.getdata();
                b.display();

                Console.WriteLine("--------------------book 1 details ------------------------");
                Book b1 = new Book();
                b1.getdata(111, "csharp", "martin", 2000);
                b1.display();

                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("enter book id : ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter book title : ");
                string tit = Console.ReadLine();
                Console.WriteLine("enter book author : ");
                string aut = Console.ReadLine();
                Console.WriteLine("enter book price : ");
                int pri = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("------------------------book 2 details ---------------------");

                Book b2 = new Book();
                b2.getdata(id, tit, aut, pri);
                b2.display();


                Console.ReadKey();
            }
        }
    }
}