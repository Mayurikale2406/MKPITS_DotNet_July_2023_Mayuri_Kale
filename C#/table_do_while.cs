using System;
using System.Runtime.Intrinsics.X86;

namespace program
{
    class program
    {
        public static void Main()
        {
            int num;
            Console.WriteLine("enter a number ");
            num = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            int counter = 1;
            do
            {
                result = num * counter;
                Console.WriteLine("{0} * {1} = {2}", num, counter, result);
                counter++;

            }
            while (counter <= 10);
            {
               
                Console.ReadKey();

            }
        }
    }
}