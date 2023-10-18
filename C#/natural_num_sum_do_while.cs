using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace program
{
    class program
    {
        public static void Main()
        {
            int num = 1;
            int sum =0;
            do
            {
                Console.WriteLine("natural num : " + num);

                sum += num;
                num++;
            }
                
            
            while (num <= 7);
            Console.WriteLine("sum : " + sum);

        }
    }
}