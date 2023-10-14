using System;
using System.Collections.Generic;

namespace oddprogram
{
    class program
    {
        public static void Main()
        {
            int x, y;
            Console.WriteLine("enter a value of x : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a value of y : ");
            y = Convert.ToInt32(Console.ReadLine());

            if (x > 0 && y > 0)
                Console.WriteLine("First quadrant");
            else if (x < 0 && y > 0)
                Console.WriteLine("second quadrant");
            else if (x < 0 && y < 0)
                Console.WriteLine("third quadrant");
            else
                Console.WriteLine("fourth quadrant");

            Console.ReadKey();

        }
    }
}