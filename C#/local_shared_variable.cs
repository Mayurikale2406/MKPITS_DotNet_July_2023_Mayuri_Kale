using System;
namespace program
{
    class program
    {
        static int num = 20;
        static void display()
        {
            int num = 10;
            Console.WriteLine("num inside method" + num);
        }
        static void Main()
        {
            display();
            Console.WriteLine("num(shared)" + num);
            Console.ReadKey();
        }
    }
}