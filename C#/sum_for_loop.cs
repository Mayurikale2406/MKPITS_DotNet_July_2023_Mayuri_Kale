using System;
using System.Diagnostics.CodeAnalysis;

namespace program
{
    class program
    {
        public static void Main()
        {
            int num;
            int sum = 0;
            for(int cnt=1; cnt<=5; cnt++)
            {
                
                Console.WriteLine("enter a number ");
                num = Convert.ToInt32(Console.ReadLine());
                sum = sum + num;

            }
            Console.WriteLine("result : " + sum);


        }
    }
}