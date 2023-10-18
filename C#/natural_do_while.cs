using System;
using System.Diagnostics;

namespace program
{
    class program
    {
        public static void Main()
        {
            int num = 1;
            do
            {
                Console.WriteLine("natural num : " + num);
                num++;
            }
            while (num <= 10);
            Console.ReadKey();

        }
    }
}