using System;
using System.Diagnostics.CodeAnalysis;

namespace program
{
    class program
    {
        public static void Main()
        {
            int num = 1;
            int sum=0;

            while (num <= 10)
            {
                Console.WriteLine(num);
                
                sum += num;
                num++;

                
            }
            Console.WriteLine("result " + sum);
            Console.ReadKey();
        }
    }
}