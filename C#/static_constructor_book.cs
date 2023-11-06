using System;
namespace program
{
    class Book
    {
        static string title;
        static string author;
        static Book()
        {
            Console.WriteLine("static constructor called");
            title = "dotnet";
            author = "vrushali";
        }
        public static void display()
        {
            Console.WriteLine("title : " + title);
            Console.WriteLine("author : " + author);
        }

    }
    class program
    {
        static void Main()
        {
            Book.display();
            Console.ReadKey();
        }
    }
}