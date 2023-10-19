using System;
using System.Runtime.Intrinsics.X86;

namespace program
{
    class program
    {
        public static void Main()
        {
            int num=1;
            int sum = 0;

            for (num = 1; num <= 10; num++)
            {
                if (num % 2 ==0)
                {
                    Console.WriteLine("odd no ", num);
                    sum = sum + num;
                }
                Console.WriteLine("sum : " + sum);
            }
        }
    }
}