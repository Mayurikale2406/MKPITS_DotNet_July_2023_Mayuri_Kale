using System;
namespace oddprogram
{
    class program
    {
        public static void Main()
        {
            int m;
            Console.WriteLine("enter a value of m");
            m = Convert.ToInt32(Console.ReadLine());

            if (m > 0)
                Console.WriteLine("n=1");
            else
                Console.WriteLine("n=-1");

            Console.ReadKey();
        }
    }
}