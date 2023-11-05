using System;

namespace LibraryProgram
{
    class LibraryBook
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; set; }

     
        public LibraryBook(string title, string author, bool isAvailable)
        {
            Title = title;
            Author = author;
            IsAvailable = isAvailable;
        }

        public void Display()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Is Available: " + IsAvailable);
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            
            LibraryBook[] books = new LibraryBook[3];
            books[0] = new LibraryBook("book1 ","author 1",true);
            books[1] = new LibraryBook("book2 " , "author 2" ,false);
            books[2] = new LibraryBook("book3" , "author 3",true);

            Console.WriteLine("Available Books:");

            for (int i = 0; i < 3; i++)
            {
               
                if (books[i].IsAvailable)
                {
                    books[i].Display();
                }
            }
        }
    }
}

