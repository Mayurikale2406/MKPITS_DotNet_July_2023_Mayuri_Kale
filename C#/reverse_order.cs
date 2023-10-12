using System;
namespace program
{
    class program
    {
        public static void Main()
        {
            char c1, c2, c3;
            Console.WriteLine("enter a letter : ");
            c1 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("enter a letter : ");
            c2 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("enter a letter : ");
            c3 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("letter : " + c3);
            Console.WriteLine("letter : " + c2);
            Console.WriteLine("letter : " + c1);
            Console.ReadKey();


        }
    }
}