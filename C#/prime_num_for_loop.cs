using System;
using System.Runtime.Intrinsics.X86;

namespace program
{
    class program
    {
        public static void Main()
        {
            int num;
            Console.WriteLine("Enter a number : ");
            num = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            int cnt = 1;
            
            for( cnt=1;cnt<=10;cnt++)
            {
                result = num * cnt;
                Console.WriteLine("{0} * {1} = {2}", num, cnt, result);
            }
            

            Console.ReadKey();
        }
    }
}