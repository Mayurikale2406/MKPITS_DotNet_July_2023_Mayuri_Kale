using System;
using System.Diagnostics;

namespace program
{
    class program
    {
        public static void Main()
        {
            int num, sqr;
            char choice = 'y';
            do
            {
                Console.WriteLine("enter a number : ");
                num = Convert.ToInt32(Console.ReadLine());
                sqr = num * num;
                Console.WriteLine("square : " + sqr);
                Console.WriteLine("do you want to continue,presee  y or n");
                choice = Convert.ToChar(Console.ReadLine());
            }
            while (choice == 'y' || choice == 'Y');
            Console.ReadKey();


            
        }
    }
}
