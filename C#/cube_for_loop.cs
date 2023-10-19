using System;
using System.Runtime.Intrinsics.X86;

namespace program
{
    class program
    {
        public static void Main()
        {
            int num;
            int result = 0;
            int cnt;
            
            
           
            Console.WriteLine("enter number of terms : ");
            num = Convert.ToInt32(Console.ReadLine());
            for (
                cnt = 1; cnt <= num; cnt++)
            {
                result = cnt * cnt * cnt;


                Console.WriteLine("num is : {0} and cube of the {1} is {2}", cnt, cnt, result);
            }
            Console.ReadKey();
        }
    }
}
