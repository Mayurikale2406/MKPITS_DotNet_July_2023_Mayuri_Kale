using System;
namespace program
{
    class Book
    {
        string title;
        string author;
        int publicationyear;
        
        public void getdata(string title,string author,int publicationyear)
        {
            this.author = author;
            this.title = title;
            this.publicationyear = publicationyear;

        }
        public void displaydata()
        {
            Console.WriteLine("author : " + author);
            Console.WriteLine("title : " + title);
            Console.WriteLine("publicationyear : " + publicationyear);
        }
        static void Main()
        {
            Book[] bookied = new Book[3];
            bookied[0] = new Book();
            bookied[1] = new Book();
            bookied[2] = new Book();
            string auth = null;
            string tit = null;
            int publication = 0;

            for(int i=0;i<3;i++)
            {
                Console.WriteLine("enter author : ");
                auth = Console.ReadLine();

                Console.WriteLine("enter title : ");
                tit = Console.ReadLine();

                Console.WriteLine("enter publicationyear : ");
                publication = Convert.ToInt32(Console.ReadLine());

                bookied[i].getdata(auth, tit, publication);


            }
            for(int i=0;i<3;i++)
            {
                bookied[i].displaydata();
            }
            Console.ReadKey();
        }
    }
}